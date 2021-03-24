using System;
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

            CarAddTest(ref carManager);
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
            });
        }

        private static void CarUpdateTest(ref CarManager carManager)
        {
            throw new NotImplementedException();
        }

        private static void CarDeleteTest(ref CarManager carManager)
        {
            throw new NotImplementedException();
        }

        private static void CarDetailsTest(ref CarManager carManager)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Color Test

        private static void ColorGetTest(ref ColorManager colorManager)
        {
            throw new NotImplementedException();
        }

        private static void ColorDeleteTest(ref ColorManager colorManager)
        {
            throw new NotImplementedException();
        }

        private static void ColorUpdateTest(ref ColorManager colorManager)
        {
            throw new NotImplementedException();
        }

        private static void ColorAddTest(ref ColorManager colorManager)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Brand Test

        private static void BrandtGetTest(ref BrandManager brandManager)
        {
            throw new NotImplementedException();
        }

        private static void BrandtDeleteTest(ref BrandManager brandManager)
        {
            throw new NotImplementedException();
        }

        private static void BrandUpdateTest(ref BrandManager brandManager)
        {
            throw new NotImplementedException();
        }

        private static void BrandAddTest(ref BrandManager brandManager)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}