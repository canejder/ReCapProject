using System;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            BrandAddTest(ref brandManager);
            // BrandUpdateTest(ref brandManager);
            // BrandtDeleteTest(ref brandManager);
            BrandtGetTest(ref brandManager);
            
            ColorAddTest(ref colorManager);
            // ColorUpdateTest(ref colorManager);
            // ColorDeleteTest(ref colorManager);
            ColorGetTest(ref colorManager);

            CarAddTest(ref carManager);
            //CarUpdateTest(ref carManager);
            //CarDeleteTest(ref carManager);
            CarDetailsTest(ref carManager);

        }

        #region Car Test

        private static void CarAddTest(ref CarManager carManager)
        {
            Console.WriteLine(
            carManager.Add(new Car
            {
                CarName = "Passat",
                ModelYear = new DateTime(1996,1,1),
                Description = "Sedan Aile Arabası",
                DailyPrice = 200,
                BrandId = 1,
                ColorId = 1
            }).Message);
            Console.WriteLine(
            carManager.Add(new Car
            {
                CarName = "Clio",
                ModelYear = new DateTime(2004,1,1),
                Description = "Hatchback 3 Kapı",
                DailyPrice = 120,
                BrandId = 6,
                ColorId = 2,
            }).Message);
        }

        private static void CarUpdateTest(ref CarManager carManager)
        {
            var entity = carManager.GetById(2).Data.SingleOrDefault();
            entity.BrandId = 1;
            carManager.Update(entity);
        }

        private static void CarDeleteTest(ref CarManager carManager)
        {
            var entity = carManager.GetById(2).Data.SingleOrDefault();//TODO: Single entites should not return a list
            carManager.Delete(entity);
        }

        private static void CarDetailsTest(ref CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
            }
        }

        #endregion

        #region Color Test

        private static void ColorGetTest(ref ColorManager colorManager)
        {
            
            foreach (var color in colorManager.GetById(1).Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorDeleteTest(ref ColorManager colorManager)
        {
            var entity = colorManager.GetAllByName("Mavi");
            colorManager.Delete(entity.Data.SingleOrDefault());
        }

        private static void ColorUpdateTest(ref ColorManager colorManager)
        {
            var entity = colorManager.GetAllByName("Mavi");
            entity.Data.SingleOrDefault().ColorName = "Blue";
            colorManager.Update(entity.Data.SingleOrDefault());
        }

        private static void ColorAddTest(ref ColorManager colorManager)
        {
            colorManager.Add(new Color
            {
                ColorName = "Green"
            });
            colorManager.Add(new Color
            {
                ColorName = "Yellow"
            });
        }

        #endregion

        #region Brand Test

        private static void BrandtGetTest(ref BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAllByName("Volkswagen").Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void BrandtDeleteTest(ref BrandManager brandManager)
        {
            var entity = brandManager.GetAllByName("Reno")?.Data.SingleOrDefault();
            brandManager.Delete(entity);
        }

        private static void BrandUpdateTest(ref BrandManager brandManager)
        {
            var entity = brandManager.GetAllByName("Skoda")?.Data.SingleOrDefault();
            entity.BrandName = "Volkswagen";
            brandManager.Update(entity);
        }

        private static void BrandAddTest(ref BrandManager brandManager)
        {
            brandManager.Add(new Brand
            {
                BrandName = "Renault"
            });
            brandManager.Add(new Brand
            {
               BrandName = "Opel"
            });
        }

        #endregion
    }
}