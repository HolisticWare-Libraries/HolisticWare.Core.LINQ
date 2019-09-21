using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Linq.ReImplemented
{
    public static partial class MemoryExtensions
    {
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>
                                                (
                                                    this Memory<TOuter> outer,
                                                    Memory<TInner> inner,
                                                    Func<TOuter, TKey> outerKeySelector,
                                                    Func<TInner, TKey> innerKeySelector,
                                                    Func<TOuter, IEnumerable<TInner>, TResult> resultSelector
                                                )
        {
            ILookup<TKey, TInner> innerLookup = inner.ToLookup(innerKeySelector);
            foreach (TOuter outerElement in outer)
            {
                TKey key = outerKeySelector(outerElement);
                IEnumerable<TInner> innerMatches;
                if (innerLookup.Contains(key))
                {
                    innerMatches = innerLookup[key];
                }
                else
                {
                    innerMatches = this.Empty<TInner>();
                }
                yield return resultSelector(outerElement, innerMatches);
            }
        }
    }
}
