using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserDal : IUserDal
    {
       
       [At("")]
        public void CreateAccount(User user)
        {
            Console.WriteLine("userdal create account");
        }



        public void LoginAccount(User user)
        {
            
        }
    }
}
