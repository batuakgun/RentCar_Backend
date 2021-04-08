using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             
                             select new CarDetailDto {CarId=c.CarId,ColorName=r.ColorName,BrandName=b.BrandName,DailyPrice=c.DailyPrice,Descriptions=c.Descriptions,ModelYear=c.ModelYear, ImagePath=c.ImagePath , MinFindexScore=c.MinFindexScore};
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetail(int carId)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from car in context.Cars.Where(c => c.CarId == carId)

                             join color in context.Colors
                             on car.ColorId equals color.ColorId

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new CarDetailDto()
                             {
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Descriptions = car.Descriptions,
                                 ModelYear = car.ModelYear,
                                 CarId = car.CarId,
                                 //MinFindexScore = car.MinFindexScore
                             };

                return result.SingleOrDefault();
            }
        }
    }
}