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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderService)
        {
            _orderDal = orderService;
        }

        public List<Order> GetAll()
        {
           return _orderDal.GetList();
        }

        public void TDelete(Order p)
        {
            _orderDal.Delete(p);
        }

        public Order TGetById(int id)
        {
          return _orderDal.GetById (id);
        }

        public void TInsert(Order p)
        {
           _orderDal.Insert(p);
        }

        public void TUpdate(Order p)
        {
            _orderDal.Update(p);
        }
    }
}
