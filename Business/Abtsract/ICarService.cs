using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abtsract
{                              
    public interface ICarService
    {
        List<Car> GetAll();

    }
}
