using System;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var carPlant = new CarPlant();

            Conveyor builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
        }
    }
}
