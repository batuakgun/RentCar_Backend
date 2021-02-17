using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {


            if (rental.RentDate >= DateTime.Now.Date)
            {
                if (rental.ReturnDate <= DateTime.Now.Date)
                {
                    _rentalDal.Add(rental);

                    return new SuccessResult(Messages.RentalAdded);

                }
                else
                {
                    return new SuccessResult(Messages.BrandNameInvalid);
                }

            }
            else
            {
                return new SuccessResult(Messages.BrandNameInvalid);
            }
        }

        

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalsListed);
        }

        public IDataResult<Rental> GetRentalByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId==rentalId)); 
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Updated");
        }
    }
}
