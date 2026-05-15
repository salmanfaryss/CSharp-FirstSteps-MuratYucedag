using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Dapper.Dtos
{
    public class ResultBookDto
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int BookPageCount { get; set; }
    }
}
