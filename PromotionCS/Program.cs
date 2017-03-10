using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();
            ProductMenu();
        }

        public static void Login()
        {
            bool authenticated = false;
            while (!authenticated)
            {
                Console.WriteLine("Enter you username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter you password:");
                string password = Console.ReadLine();

                Member temp = Members.GetMember(username);
                if(temp.Password == password)
                {
                    authenticated = true;
                }
            }

            Console.WriteLine("Logged In\n\n");
        }

        public static void ProductMenu()
        {
            Console.WriteLine("How to use:\n" + "Q:exit\nshow: show all products\nadd: Add new product\n\n");
            
            while(true)
            {                
                string key = Console.ReadLine();
                if(key=="Q")
                {
                    break;
                }
                else if(key=="show")
                {
                    List<Product> prods = Products.ShowProducts();
                    foreach(Product prod in prods)
                    {
                        Console.WriteLine("Sku:" + prod.Sku + " Name:" + prod.Name + "  Price:" + prod.Price);
                    }
                }
                else if(key=="add")
                {
                    Console.WriteLine("Sku:");
                    string sku = Console.ReadLine();
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price:");
                    string price = Console.ReadLine();

                    Products.AddProduct(sku, name, Convert.ToDouble(price));
                }
            }
        }
    }
}
