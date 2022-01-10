using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Business
{
    public class KategoriRepository : IRepository<Kategori>
    {
        public CafeContext Context { get; set; }

        public void Add(Kategori item)
        {
            Context.Kategoriler.Add(item);
            Context.Save();
        }

        public Kategori Get(Guid id)
        {
            return Context.Kategoriler.FirstOrDefault(k => k.Id == id);
        }

        public List<Kategori> GetAll(Func<Kategori, bool> predicate = null)
        {
            return predicate == null ? Context.Kategoriler : Context.Kategoriler.Where(predicate).ToList();
        }

        public void Remove(Kategori item)
        {
            Context.Kategoriler.Remove(item);
            Context.Save();
        }

        public void Update()
        {
            Context.Save();
        }
    }
}
