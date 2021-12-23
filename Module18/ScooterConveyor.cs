using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class ScooterConveyor : Conveyor 
    {
        public ScooterConveyor()
        {
            product = new Product("Скутер");
        }

        public override void BuildFrame()
        {
            product["frame"] = "Рама скутера";
        }

        public override void BuildEngine()
        {
            product["engine"] = "25 л.с.";
        }

        public override void BuildWheels()
        {
            product["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            product["doors"] = "0";
        }
    }
}
