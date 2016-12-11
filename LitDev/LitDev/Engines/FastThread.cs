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
            if (UseExpression)
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
            if (UseExpression)
            {
                if (null == _FuncInvoke) _FuncInvoke = MagicFunc(methodInvokeWithReturn);
                return _FuncInvoke(helper);
            }
            else
            {
                return methodInvokeWithReturn.Invoke(null, new object[] { helper });
            }
        }

        public static void Action(MethodInfo method, InvokeHelper helper = null)
        {
            if (null == helper)
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
            else
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
                    _Action0();
                }
                else
                {
                    method.Invoke(null, new object[] { helper });
                }
            }
        }

        public static object Func(MethodInfo method, InvokeHelperWithReturn helper = null)
        {
            if (null == helper)
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
            else
            {
                if (UseExpression)
                {
                    if (!_Func1s.TryGetValue(method, out _Func1))
                    {
                        var parameter = method.GetParameters().Single();
                        var argument = Expression.Parameter(typeof(object), "argument");
                        var methodCall = Expression.Call(null, method, Expression.Convert(argument, parameter.ParameterType) );
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
