using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context =new RentCarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users1
                             on c.UserId equals u.Id
                             join r in context.Rentals
                             on c.CustomerId equals r.CustomerId
                             join a in context.Cars
                             on r.CarId equals a.CarId
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             join o in context.Colors
                             on a.ColorId equals o.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId=r.RentalId,CustomerName=c.CustomerName,FirstName=u.FirstName,LastName=u.LastName,
                                 BrandName=b.BrandName,CarId=a.CarId,ModelYear=a.ModelYear,DailyPrice=a.DailyPrice,
                                 ColorName=o.ColorName,Descriptions=a.Descriptions,Email=u.Email,RentDate=r.RentDate

                             };


                return result.ToList();
            }
        }
    }
}
