using _09_Katman.BussinessLayer.Abstract;
using _09_Katman.DataAccesLayer.Abstract;
using _09_Katman.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void TDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category p)
        {
           _categoryDal.Insert(p);
        }

        public void TUpdate(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
