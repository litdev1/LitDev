using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;

namespace LitDev.Engines
{
    class FastThread
    {
        private static MethodInfo methodBeginInvoke = typeof(GraphicsWindow).GetMethod("BeginInvoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvoke = typeof(GraphicsWindow).GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvokeWithReturn = typeof(GraphicsWindow).GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodClearDispatcherQueue = typeof(SmallBasicApplication).GetMethod("ClearDispatcherQueue", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);

        private static Action<object> _ActionInvoke = null;
        private static Func<object, object> _FuncInvoke = null;

        private static Dictionary<MethodInfo, Action> _Action0s = new Dictionary<MethodInfo, Action>();
        private static Action _Action0;

        public static bool UseExpression = true;

        public static void BeginInvoke(InvokeHelper helper)
        {
            if (UseExpression)
            {
                BeginInvokeActon(helper);
            }
            else
            {
                methodBeginInvoke.Invoke(null, new object[] { helper });
            }
        }

        public static void Invoke(InvokeHelper helper)
        {
            if (UseExpression)
            {
                InvokeActon(helper);
            }
            else
            {
                methodInvoke.Invoke(null, new object[] { helper });
            }
        }

        public static object InvokeWithReturn(InvokeHelperWithReturn helper)
        {
            if (UseExpression)
            {
                return InvokeFunc(helper);
            }
            else
            {
                return methodInvokeWithReturn.Invoke(null, new object[] { helper });
            }
        }

        public static void Action0(MethodInfo method)
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

        private static Action<object> InvokeActon
        {
            get
            {
                if (null == _ActionInvoke) _ActionInvoke = MagicAction(methodInvoke);
                return _ActionInvoke;
            }
        }

        private static Action<object> BeginInvokeActon
        {
            get
            {
                if (null == _ActionInvoke) _ActionInvoke = MagicAction(methodBeginInvoke);
                return _ActionInvoke;
            }
        }

        private static Func<object, object> InvokeFunc
        {
            get
            {
                if (null == _FuncInvoke) _FuncInvoke = MagicFunc(methodInvokeWithReturn);
                return _FuncInvoke;
            }
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
    }
}
