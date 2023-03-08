using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class Kitab
    {
        private int _pageCount;
        private string _name;
        public string Name { get=> _name; set
            {
                if(value.Length >= 3)
                {
                    _name = value;
                }

            } }
        public int PageCount { get=>_pageCount; set
            {
                if (value >= 10)
                {
                    _pageCount = value;
                }
            }

        }
        public Kitab(string name, int pageCount)
        {

                Name = name;
                PageCount = pageCount;
            
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + Name + " Count : " + PageCount);
        }

    }
}
