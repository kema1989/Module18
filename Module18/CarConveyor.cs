using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    /// <summary>
    /// Строитель машин
    /// </summary>
    class CarConveyor : Conveyor
    {
        public CarConveyor()
        {
            product = new Product("Автомобиль");
        }

        public override void BuildFrame()
        {
            product["frame"] = "Рама автомобиля";
        }

        public override void BuildEngine()
        {
            product["engine"] = "150 л.с.";
        }

        public override void BuildWheels()
        {
            product["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }
    }
}
