using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetRentalByRentalId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails());
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("User Updated");
        }
    }
}
