using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.DataAccesLayer.Abstract
{
    public interface IGenericDal<T>
    {
        List<T> GetList();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        T GetById (int id);

        
    }
}
