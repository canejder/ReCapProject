using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("-------------::::::***--Cars--***::::::-------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Yılı: "+car.ModelYear+" Açıklaması: "+car.Description);
            }
            Console.WriteLine("-------------::::::***--------***::::::-------------");
            
        }
    }
}