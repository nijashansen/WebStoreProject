using System.Collections;
using System.Collections.Generic;

namespace Core.DomainServices.Filtering
{
    public class FilteringList<T>
    {
        public IEnumerable<T> List { get; set; }
        public int Count { get; set; }
    }
}