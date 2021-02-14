﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        
       

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

       

        

        public void Update(Car car)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
                       
        }
    }
}
