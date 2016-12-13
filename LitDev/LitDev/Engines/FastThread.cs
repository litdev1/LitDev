using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using System.Drawing;

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

        public static void BeginInvoke(InvokeHelper helper)
        {
            if (UseExpression)
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
            if (UseDispatcher)
            {
                _dispatcher.Invoke(DispatcherPriority.Render, helper);
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
                return _dispatcher.Invoke(DispatcherPriority.Render, helper);
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

        private delegate void SaveImage_Type(string imageName, Bitmap bitmap);
        private static SaveImage_Type del_SaveImage = SaveImage_Delegate;
        private static void SaveImage_Delegate(string imageName, Bitmap bitmap)
        {
            _savedImages[imageName] = FastPixel.GetBitmapImage(bitmap);
        }
        public static void SaveImage(string imageName, Bitmap bitmap)
        {
            _dispatcher.Invoke(DispatcherPriority.Render, del_SaveImage, new object[] { imageName, bitmap });
        }

        private delegate void SaveBitmapSource_Type(string imageName, BitmapSource bitmapSource);
        private static SaveBitmapSource_Type del_SaveBitmapSource = SaveBitmapSource_Delegate;
        private static void SaveBitmapSource_Delegate(string imageName, BitmapSource bitmapSource)
        {
            _savedImages[imageName] = bitmapSource;
        }
        public static void SaveBitmapSource(string imageName, BitmapSource bitmapSource)
        {
            _dispatcher.Invoke(DispatcherPriority.Render, del_SaveBitmapSource, new object[] { imageName, bitmapSource });
        }
    }
}
