using System.Collections.Generic;

namespace Core.Linq
{
    public interface IGrouping<TKey,TElement> : IEnumerable<TElement>
    {
        TKey Key { get; }
    }
}
