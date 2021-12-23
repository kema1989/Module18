using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class Product
    {
        private string type;

        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public Product(string type)
        {
            this.type = type;
        }

        public string this[string key]
        {
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {type}");
            Console.WriteLine($"Рама: {parts["frame"]}");
            Console.WriteLine($"Двигатель: {parts["engine"]}");
            Console.WriteLine($"Колеса: {parts["wheels"]}");
            Console.WriteLine($"Двери: {parts["doors"]}");
        }
    }
}
