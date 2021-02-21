﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
