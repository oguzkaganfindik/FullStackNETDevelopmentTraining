using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091__Encapsulation
{
    internal class Person
    {
        // private yazılmasa bile otomatik private atanır.
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }


        private int _age; // field
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
                else
                    Console.WriteLine("NEGATİF BİR YAŞ GİREMEZSİNİZ. DEĞER ATANAMADI.");
            }
        }
    }
}
