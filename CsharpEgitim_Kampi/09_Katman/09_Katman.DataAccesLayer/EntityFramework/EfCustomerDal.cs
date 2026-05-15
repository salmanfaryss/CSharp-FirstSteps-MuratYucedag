using _09_Katman.DataAccesLayer.Abstract;
using _09_Katman.DataAccesLayer.Repositories;
using _09_Katman.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.DataAccesLayer.EntityFramework
{
    public class EfCustomerDal: GenericRepository<Customer>, ICustomerDal
    {
    }
}
