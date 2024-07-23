//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Reflection.Emit;

namespace LitDev.Engines
{
    class FastThread
    {
        private static MethodInfo methodBeginInvoke = typeof(SmallBasicApplication).GetMethod("BeginInvoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvoke = typeof(SmallBasicApplication).GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvokeWithReturn = typeof(SmallBasicApplication).GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);

        private static Action<object> _ActionInvoke = null;
        private static Func<object, object> _FuncInvoke = null;

        private static Dictionary<MethodInfo, Action> _Action0s = new Dictionary<MethodInfo, Action>();
        private static Action _Action0;
        private static Dictionary<MethodInfo, Action<object>> _Action1s = new Dictionary<MethodInfo, Action<object>>();
        private static Action<object> _Action1;

        private static Dictionary<MethodInfo, Func<object>> _Func0s = new Dictionary<MethodInfo, Func<object>>();
        private static Func<object> _Func0;
        private static Dictionary<MethodInfo, Func<object, object>> _Func1s = new Dictionary<MethodInfo, Func<object, object>>();
        private static Func<object, object> _Func1;

        private static Dispatcher _dispatcher = (Dispatcher)typeof(SmallBasicApplication).GetField("_dispatcher", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        private static Dictionary<string, BitmapSource> _savedImages = (Dictionary<string, BitmapSource>)typeof(ImageList).GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

        public static bool UseDispatcher = true;
        public static bool UseExpression = true;
        public enum eForce { NONE, INVOKE, BEGININVOKE};
        public static eForce force = eForce.NONE;
        public static DispatcherPriority priority = DispatcherPriority.Render;

        public static void BeginInvoke(InvokeHelper helper)
        {
            if (force == eForce.INVOKE)
            {
                Invoke(helper);
            }
            else if (UseDispatcher)
            {
                _dispatcher.BeginInvoke(priority, helper);
            }
            else if (UseExpression)
            {
                if (null == _ActionInvoke) _ActionInvoke = MagicAction(methodBeginInvoke);
                _ActionInvoke(helper);
            }
            else
            {
                methodBeginInvoke.Invoke(null, new object[] { helper });
            }
        }

        public static void Invoke(InvokeHelper helper)
        {
            if (force == eForce.BEGININVOKE)
            {
                BeginInvoke(helper);
            }
            else if (UseDispatcher)
            {
                _dispatcher.Invoke(priority, helper);
            }
            else if (UseExpression)
            {
                if (null == _ActionInvoke) _ActionInvoke = MagicAction(methodInvoke);
                _ActionInvoke(helper);
            }
            else
            {
                methodInvoke.Invoke(null, new object[] { helper });
            }
        }

        public static object InvokeWithReturn(InvokeHelperWithReturn helper)
        {
            if (UseDispatcher)
            {
                return _dispatcher.Invoke(priority, helper);
            }
            else if (UseExpression)
            {
                if (null == _FuncInvoke) _FuncInvoke = MagicFunc(methodInvokeWithReturn);
                return _FuncInvoke(helper);
            }
            else
            {
                return methodInvokeWithReturn.Invoke(null, new object[] { helper });
            }
        }

        public static void Action(MethodInfo method)
        {
            if (UseExpression)
            {
                if (!_Action0s.TryGetValue(method, out _Action0))
                {
                    var methodCall = Expression.Call(null, method);
                    _Action0 = Expression.Lambda<Action>(methodCall).Compile();
                    _Action0s[method] = _Action0;
                }
                _Action0();
            }
            else
            {
                method.Invoke(null, new object[] { });
            }
        }

        public static void Action<T>(MethodInfo method, T helper)
        {
            if (UseExpression)
            {
                if (!_Action1s.TryGetValue(method, out _Action1))
                {
                    var parameter = method.GetParameters().Single();
                    var argument = Expression.Parameter(typeof(object), "argument");
                    var methodCall = Expression.Call(null, method, Expression.Convert(argument, parameter.ParameterType));
                    _Action1 = Expression.Lambda<Action<object>>(methodCall, argument).Compile();
                    _Action1s[method] = _Action1;
                }
                _Action1(helper);
            }
            else
            {
                method.Invoke(null, new object[] { helper });
            }
        }

        public static object Func(MethodInfo method)
        {
            if (UseExpression)
            {
                if (!_Func0s.TryGetValue(method, out _Func0))
                {
                    var methodCall = Expression.Call(null, method);
                    _Func0 = Expression.Lambda<Func<object>>(methodCall).Compile();
                    _Func0s[method] = _Func0;
                }
                return _Func0();
            }
            else
            {
                return method.Invoke(null, new object[] { });
            }
        }

        public static object Func<T>(MethodInfo method, T helper)
        {
            if (UseExpression)
            {
                if (!_Func1s.TryGetValue(method, out _Func1))
                {
                    var parameter = method.GetParameters().Single();
                    var argument = Expression.Parameter(typeof(object), "argument");
                    var methodCall = Expression.Call(null, method, Expression.Convert(argument, parameter.ParameterType));
                    _Func1 = Expression.Lambda<Func<object, object>>(methodCall, argument).Compile();
                    _Func1s[method] = _Func1;
                }
                return _Func1(helper);
            }
            else
            {
                return method.Invoke(null, new object[] { helper });
            }
        }

        public static Dispatcher Dispatcher
        {
            get { return _dispatcher; }
        }

        private static Action<object> MagicAction(MethodInfo method)
        {
            var parameter = method.GetParameters().Single();
            var argument = Expression.Parameter(typeof(object), "argument");
            var methodCall = Expression.Call(
                null,
                method,
                Expression.Convert(argument, parameter.ParameterType)
                );
            return Expression.Lambda<Action<object>>(methodCall, argument).Compile();
        }

        private static Func<object, object> MagicFunc(MethodInfo method)
        {
            var parameter = method.GetParameters().Single();
            var argument = Expression.Parameter(typeof(object), "argument");
            var methodCall = Expression.Call(
                null,
                method,
                Expression.Convert(argument, parameter.ParameterType)
                );
            return Expression.Lambda<Func<object, object>>(methodCall, argument).Compile();
        }

        private static Action<T, object> MagicAction<T>(MethodInfo method)
        {
            var parameter = method.GetParameters().Single();
            var instance = Expression.Parameter(typeof(T), "instance");
            var argument = Expression.Parameter(typeof(object), "argument");
            var methodCall = Expression.Call(
                instance,
                method,
                Expression.Convert(argument, parameter.ParameterType)
                );
            return Expression.Lambda<Action<T, object>>(
                Expression.Convert(methodCall, typeof(object)),
                instance, argument
                ).Compile();
        }

        private static Func<T, object, object> MagicFunc<T>(MethodInfo method)
        {
            var parameter = method.GetParameters().Single();
            var instance = Expression.Parameter(typeof(T), "instance");
            var argument = Expression.Parameter(typeof(object), "argument");
            var methodCall = Expression.Call(
                instance,
                method,
                Expression.Convert(argument, parameter.ParameterType)
                );
            return Expression.Lambda<Func<T, object, object>>(
                Expression.Convert(methodCall, typeof(object)),
                instance, argument
                ).Compile();
        }

        private static string _imageName;
        private static Bitmap _bitmap;
        private static BitmapSource _bitmapSource;
        private static bool _bCopy;
        private static void SaveBitmap_Delegate()
        {
            if (_bCopy)
                _savedImages[_imageName] = FastPixel.GetBitmapImage(_bitmap).Clone();
            else
                _savedImages[_imageName] = FastPixel.GetBitmapImage(_bitmap);
        }
        public static void SaveBitmap(string imageName, Bitmap bitmap, bool bCopy = false)
        {
            _imageName = imageName;
            _bitmap = bitmap;
            Invoke(SaveBitmap_Delegate);
        }

        private static void SaveBitmapSource_Delegate()
        {
            if (_bCopy)
                _savedImages[_imageName] = _bitmapSource.Clone();
            else
                _savedImages[_imageName] = _bitmapSource;
        }
        public static void SaveBitmapSource(string imageName, BitmapSource bitmapSource, bool bCopy = false)
        {
            _imageName = imageName;
            _bitmapSource = bitmapSource;
            _bCopy = bCopy;
            Invoke(SaveBitmapSource_Delegate);
        }

        public static Func<T> CreateGetter<T>(FieldInfo field)
        {
            string methodName = field.ReflectedType.FullName + ".get_" + field.Name;
            DynamicMethod setterMethod = new DynamicMethod(methodName, typeof(T), null, true);
            ILGenerator gen = setterMethod.GetILGenerator();
            if (field.IsStatic)
            {
                gen.Emit(OpCodes.Ldsfld, field);
            }
            else
            {
                gen.Emit(OpCodes.Ldarg_0);
                gen.Emit(OpCodes.Ldfld, field);
            }
            gen.Emit(OpCodes.Ret);
            return (Func<T>)setterMethod.CreateDelegate(typeof(Func<T>));
        }

        public static Action<T> CreateSetter<T>(FieldInfo field)
        {
            string methodName = field.ReflectedType.FullName + ".set_" + field.Name;
            DynamicMethod setterMethod = new DynamicMethod(methodName, null, new Type[1] { typeof(T) }, true);
            ILGenerator gen = setterMethod.GetILGenerator();
            if (field.IsStatic)
            {
                gen.Emit(OpCodes.Ldarg_1);
                gen.Emit(OpCodes.Stsfld, field);
            }
            else
            {
                gen.Emit(OpCodes.Ldarg_0);
                gen.Emit(OpCodes.Ldarg_1);
                gen.Emit(OpCodes.Stfld, field);
            }
            gen.Emit(OpCodes.Ret);
            return (Action<T>)setterMethod.CreateDelegate(typeof(Action<T>));
        }
    }
}
