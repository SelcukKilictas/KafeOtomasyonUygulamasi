using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Business
{
    public interface IRepository<T> where T : CafeBase
    {
        CafeContext Context { get; set; }
        T Get(Guid id);
        List<T> GetAll(Func<T,bool> predicate =null);
        void Add(T item);
        void Remove(T item);
        void Update();

    }
}
