﻿using Business.Concrete;
using System;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColourTest();
            //CarAddTest();
            //GetCarsByBrandIdTest();

            Console.ReadLine();
        }

        //private static void GetCarsByBrandIdTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarsByBrandId(1);
        //    foreach (var item in result.Data)
        //    {
        //        Console.WriteLine(item.BrandId + " " + item.Name);
        //    }
        //}

        //private static void CarAddTest()
        //{
        //    Car car1 = new Car
        //    {
        //        Id=66,
        //        BrandId = 1,
        //        ColourId = 2,
        //        Name = "bss",
        //        ModelYear = 1990,
        //        DailyPrice = 150,
        //        Description = "En iyisinin iyisi"
        //    };

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(car1);
        //}

        //private static void ColourTest()
        //{
        //    ColourManager colourManager = new ColourManager(new EfColourDal());
        //    foreach (var colour in colourManager.GetAll())
        //    {
        //        Console.WriteLine(colour.Name);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.Name);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
        //    }
        //}
    }
}
