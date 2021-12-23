using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class MotoConveyor : Conveyor
    {
        public MotoConveyor()
        {
            product = new Product("Мотоцикл");
        }
        public override void BuildFrame()
        {
            product["frame"] = "Рама мотоцикла";
        }

        public override void BuildEngine()
        {
            product["engine"] = "70 л. с.";
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
