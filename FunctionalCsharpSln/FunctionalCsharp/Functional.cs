using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace FunctionalCsharp
{
    public static class Functional
    {
        /// <summary>
        /// Given a function f : T -> U and g : U -> V, create the function f o g : T -> V such that is x is of type T, (f o g)(x) = g(f(x)).
        /// </summary>
        public static Func<T,V> Compose<T,U,V>(this Func<T,U> f, Func<U, V> g)
        {
            return (T x) => g(f(x));
        }

        /// <summary>
        /// Given a function f : T -> U and a value x of type T, compute f(x)
        /// </summary>
        public static U Pipe<T, U>(this T x, Func<T, U> f)
        {
            return f(x);
        }
    }
}
