using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abtsract
{                              
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCarId(int carId);
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByBrandId(int brandId);

    }
}
