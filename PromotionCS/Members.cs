using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionCS;

namespace PromotionCS
{
    public class Members
    {
        static Dictionary<string, Member> members = new Dictionary<string, Member>();

        static Members()
        {
            members.Add("Laudi", new Member("1", "Laudi", "Password123", "Admin"));
            members.Add("Denny", new Member("2", "Denny", "Password123", "Helper"));
            members.Add("LieBee", new Member("3", "LieBee", "Password123", "Cashier"));
            members.Add("Jolene", new Member("4", "Jolene", "Password123", "Cashier"));
        }

        public static Member GetMember(string name)
        {
            return members[name];
        }
    }
}
