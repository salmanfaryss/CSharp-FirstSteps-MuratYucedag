using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.EntityLayer.Concrete
{
    public class Product
    {
        public  int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price {  get; set; }
        public string Description { get; set; }
        public int ProductStock { get; set; }
    }
}
