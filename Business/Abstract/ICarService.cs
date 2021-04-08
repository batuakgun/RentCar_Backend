using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Update(Car car);
        IDataResult<CarDetailDto> GetCarDetail(int carId);
        IDataResult<List<CarDetailDto>> GetByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsByBrandAndColor(int brandId, int colorId);

        IResult TransactionalOperation(Car car);

    }
}
