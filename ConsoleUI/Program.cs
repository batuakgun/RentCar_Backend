using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carService = new CarManager(new InMemoryCarDal());
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
