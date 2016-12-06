using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LitDev.Engines
{
    class FastThread
    {
        private static MethodInfo methodBeginInvoke = typeof(GraphicsWindow).GetMethod("BeginInvoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvoke = typeof(GraphicsWindow).GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
        private static MethodInfo methodInvokeWithReturn = typeof(GraphicsWindow).GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);

        private static Action<object> _Action = null;
        private static Func<object, object> _Func = null;

        public static bool UseExpression = false;
        public static bool UseAsync = false;

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
                if (UseAsync) BeginInvokeActon(helper);
                else InvokeActon(helper);
            }
            else
            {
                if (UseAsync) methodBeginInvoke.Invoke(null, new object[] { helper });
                else methodInvoke.Invoke(null, new object[] { helper });
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

        private static Action<object> InvokeActon
        {
            get
            {
                if (null == _Action) _Action = MagicAction(methodInvoke);
                return _Action;
            }
        }

        private static Action<object> BeginInvokeActon
        {
            get
            {
                if (null == _Action) _Action = MagicAction(methodBeginInvoke);
                return _Action;
            }
        }

        private static Func<object, object> InvokeFunc
        {
            get
            {
                if (null == _Func) _Func = MagicFunc(methodInvokeWithReturn);
                return _Func;
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
