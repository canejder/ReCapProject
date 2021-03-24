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
            
            // BrandAddTest(ref brandManager);
            // BrandUpdateTest(ref brandManager);
            // BrandtDeleteTest(ref brandManager);
            // BrandtGetTest(ref brandManager);
            //
            // ColorAddTest(ref colorManager);
            // ColorUpdateTest(ref colorManager);
            // ColorDeleteTest(ref colorManager);
            // ColorGetTest(ref colorManager);

            // CarAddTest(ref carManager);
            // CarUpdateTest(ref carManager);
            // CarDeleteTest(ref carManager);
            // CarDetailsTest(ref carManager);
        }

        #region Car Test

        private static void CarAddTest(ref CarManager carManager)
        {
            carManager.Add(new Car
            {
                Name = "Passat",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 200,
                Description = "Sedan Aile Arabası",
                ModelYear = "1996"
            });carManager.Add(new Car
            {
                Name = "Clio",
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 200,
                Description = "Hatchback spor araba",
                ModelYear = "2004"
            });
        }

        private static void CarUpdateTest(ref CarManager carManager)
        {
            var entity = carManager.GetAll().Find(c => c.Id == 1);
            entity.BrandId = 2;
            entity.Name = "Corsa";
            carManager.Update(entity);
        }

        private static void CarDeleteTest(ref CarManager carManager)
        {
            var entity = carManager.GetAll().Find(c => c.Id == 2);
            carManager.Delete(entity);
        }

        private static void CarDetailsTest(ref CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
            }
        }

        #endregion

        #region Color Test

        private static void ColorGetTest(ref ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAllById(1))
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void ColorDeleteTest(ref ColorManager colorManager)
        {
            var entity = colorManager.GetAllByName("Mavi").SingleOrDefault();
            colorManager.Delete(entity);
        }

        private static void ColorUpdateTest(ref ColorManager colorManager)
        {
            var entity = colorManager.GetAllByName("Mavi").SingleOrDefault();
            entity.Name = "Blue";
            colorManager.Update(entity);
        }

        private static void ColorAddTest(ref ColorManager colorManager)
        {
            colorManager.Add(new Color
            {
                Name = "Mavi"
            });
        }

        #endregion

        #region Brand Test

        private static void BrandtGetTest(ref BrandManager brandManager)
        {
            foreach (var color in brandManager.GetAllByName("Volkswagen"))
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandtDeleteTest(ref BrandManager brandManager)
        {
            var entity = brandManager.GetAllByName("Volkswagen").SingleOrDefault();
            brandManager.Delete(entity);
        }

        private static void BrandUpdateTest(ref BrandManager brandManager)
        {
            var entity = brandManager.GetAllByName("Skoda").SingleOrDefault();
            entity.Name = "Volkswagen";
            brandManager.Update(entity);
        }

        private static void BrandAddTest(ref BrandManager brandManager)
        {
            brandManager.Add(new Brand
            {
                Name = "Opel"
            });
            brandManager.Add(new Brand
            {
                Name = "Volkswagen"
            });
        }

        #endregion
    }
}