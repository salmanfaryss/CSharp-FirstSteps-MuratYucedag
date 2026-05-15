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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerService;

        public CustomerManager(ICustomerDal customerService)
        {
            _customerService = customerService;
        }

        public List<Customer> GetAll()
        {
            return _customerService.GetList();
        }

        public void TDelete(Customer p)
        {
           _customerService.Delete(p);
        }

        public Customer TGetById(int id)
        {
           return _customerService.GetById(id);
        }

        public void TInsert(Customer p)
        {
            _customerService.Insert(p);
        }

        public void TUpdate(Customer p)
        {
           _customerService.Update(p);
        }
    }
}
