﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        [SecuredOperation("colour.add,moderator,admin")]
        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ProductAdded);
        }

        [SecuredOperation("colour.delete,moderator,admin")]
        public IResult Delete(Colour colour)
        {
            _colourDal.Delete(colour);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [SecuredOperation("colour.update,moderator,admin")]
        public IResult Update(Colour colour)
        {
            _colourDal.Update(colour);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Colour> GetById(int Id)
        {
            return new SuccessDataResult<Colour>(_colourDal.Get(c=>c.ColourId==Id), Messages.ProductsListed);
        }

        
    }
}
