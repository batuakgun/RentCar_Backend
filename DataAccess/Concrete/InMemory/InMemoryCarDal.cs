using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 175, ModelYear=2018, Description = " Renault Megane "},
                new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 120, ModelYear=2019, Description = " Fiat Egea "},
                new Car{Id = 3, BrandId = 3, ColorId = 4, DailyPrice = 320, ModelYear=2020, Description = " Mercedes-Benz A180d "},
                new Car{Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 245, ModelYear=2019, Description = " Volkswagen Passat "},
                new Car{Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 300, ModelYear=2017, Description = " BMW 116i "},
                new Car{Id = 6, BrandId = 6, ColorId = 3, DailyPrice = 180, ModelYear=2018, Description = " Opel Astra "}
            };
        }
        
        
       

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetCarsByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        
    }
}
