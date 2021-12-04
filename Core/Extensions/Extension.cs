using Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class CollectiveExtension
    {
        public static string Logger(this string text)
        {
            return "logglandı";
        }


        [Log]
        public static string DolarToTurkishLira(this float dolar)
        {
            return "Dolar today exchange rate 13,40 " + dolar + " equals to Turkish lira: " + dolar * 13.40;
        }

        public static string ReflactionTypeTest(object v)
        {
            throw new NotImplementedException();
        }

        public static void ReflactionTypeTest(this MethodBase methodInfo)
        {

            //var result = methodInfo.GetType().GetMember(methodInfo.ToString()).First().GetType().Name;

           
 

          //  return result;


        }

    }
}
