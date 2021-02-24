using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarDetails();



            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //AddNewRental(rentalManager);

            //var result2 = rentalManager.GetAll();
            //if (result2.Success == true)
            //{
            //    foreach (var rental2 in result2.Data)
            //    {
            //        Console.WriteLine(rental2.CustomerId);
            //    }
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Descriptions);
                }
            }


        }

        private static void GetCarDetails()
        {
            Console.WriteLine("Arabalarımız:");

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.Descriptions);
                }

            }
        }

        private static void AddNewRental(RentalManager rentalManager)
        {
            rentalManager.Add(new Rental { CarId = 2, CustomerId = 2, RentDate = new DateTime(2017, 02, 21) });
        }
    }
}
