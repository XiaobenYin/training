using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class GenericRepository<T> where T : Entity
    {
        List<T> list = new List<T>();

        public void Add(T entity)
        {
            list.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            foreach (T i in list)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;

        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
