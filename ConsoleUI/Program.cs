using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest1();
            //CarTest2();
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var car in carManager.carDetailDTOs())
            {
                Console.WriteLine(car.brandname + " " + car.colorname + " " + car.dailyprice);
            }
        }

        private static void CarTest1()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            carManager.Add()
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.description);
            }
        }
    }
}
