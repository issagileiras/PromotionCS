using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class Member
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }
        
        public Member(string ID, string Name, string Password, string AccType)
        {
            this.ID = ID;
            this.Name = Name;
            this.Password = Password;
            this.AccType = AccType;
        }
    }
}
