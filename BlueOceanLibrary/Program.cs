using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOceanLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var BlackrockLibary = new Library();
            var books = BlackrockLibary.GetAllBooks();
        }
    }
}
