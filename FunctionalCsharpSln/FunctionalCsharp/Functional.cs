using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FunctionalCsharp
{
    public static class Functional
    {
        /// <summary>
        /// Given a function f : T -> U and g : V -> W, create the function f o g : T -> W such that is x is of type T, (f o g)(x) = g(f(x)).
        /// Assumption : there is a valid conversion from U to V.
        /// </summary>
        public static Func<T,W> Compose<T,U,V,W>(this Func<T,U> f, Func<V, W> g)
        {
            return (T x) => g(ConvertValue<V,U>(f(x)));
        }

        private static T ConvertValue<T, U>(U value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
