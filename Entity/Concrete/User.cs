using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity.Concrete
{
    [ToTableAttibute("table")]
    public class User : IUser
    {
        
        
        [Required]  
        public int UserId { get; set; }
        public string UserName{ get; set; }
        public string Email { get; set; }
       
        public string Password { get; set; }
        public string UserType { get; set; }
    }

    class ToTableAttibute:Attribute
    {
        private string _tableName;

        public ToTableAttibute(string tableName)
        {
            _tableName = tableName;
        }

     
    }
}
