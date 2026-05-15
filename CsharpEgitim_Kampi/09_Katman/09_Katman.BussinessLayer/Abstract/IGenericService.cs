using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void TInsert(T p);
        void TUpdate(T p);
        void TDelete(T p);
        T TGetById (int id);
    }
}
