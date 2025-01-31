﻿using Core.Utilities.Results;
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
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColourId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandName(string brandName);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColourName(string colourName);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandNameAndColorName(string brandName, string colorName);
        IDataResult<List<CarDetailDto>> GetCarDetail(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandIdAndColorId(int brandId, int colourId);
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car); //transaction yönetimi için.
    }
}