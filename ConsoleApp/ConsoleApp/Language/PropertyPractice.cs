using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    internal class PropertyPractice
    {
        private string _name;
        public string Name
        {
            get
            {
                Console.WriteLine("GET NAME");
                return _name;
            }
            set
            {
                Console.WriteLine("SET NAME");
                _name = value;
            }
        }
        public string Value
        {
            get;
            set;
        }

        public PropertyPractice(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public void Main()
        {
            PrintPopup(title: "제목!", "메세지!!", etc: "eeeeee");
        }


        static void PrintPopup(string title, string message, string etc = "기타")
        {
            Console.WriteLine($"Print Popup!! {title} {message} {etc}");
        }
    }
}
