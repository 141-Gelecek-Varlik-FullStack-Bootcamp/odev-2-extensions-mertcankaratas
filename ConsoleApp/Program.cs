﻿using Core.Attributes;
using Core.Extensions;
using DataAccess.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. extension para biçimi formatlama
            float Dolar = 13;
            Console.WriteLine(Dolar.DolarToTurkishLira());
            Console.WriteLine(Core.Extensions.CollectiveExtension.DolarToTurkishLira(15));
            
            //2. extension reflaction
            Console.WriteLine(Core.Extensions.CollectiveExtension.TypeOfMethod(typeof(int)));
         
            

            Console.ReadLine();
           
        }


        
    }
}
