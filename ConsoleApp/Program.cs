using System;
using DataAccess.Concrete;
using Entity.Concrete;
using Extension;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. extension para biçimi formatlama
            float Dolar = 13;
            Console.WriteLine(Dolar.DolarToTurkishLira());
            Console.WriteLine(Extension.Extension.DolarToTurkishLira(15));


            UserDal userDal = new UserDal();
            userDal.CreateAccount(new User());

           
            

           

            Console.ReadLine();
           
        }
    }
}
