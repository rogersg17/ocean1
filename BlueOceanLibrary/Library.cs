using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOceanLibrary
{
   public class Library
    {
        public List<Books> GetAllBooks()
        {
            var fullBookList = new List<Books>();

            var b1 = new Books
            {
                id = 1,
                name = "My life Journey",
                category = "Autobiography"
            };

            var b2 = new Books
            {
                id = 2,
                name = "Charlie and the Chocolate Factory",
                category = "Fiction"
            };

            var b3 = new Books
            {
                id = 3,
                name = "Charles Manson Murders",
                category = "True Crime"
            };

            fullBookList.Add(b1);
            fullBookList.Add(b2);
            fullBookList.Add(b3);

            return fullBookList;

        }
    }
}
