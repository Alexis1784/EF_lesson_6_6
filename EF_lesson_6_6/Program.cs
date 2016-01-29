using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MobileContext db = new MobileContext())
            {
                Phone p1 = new Phone { Name = "Samsung Galaxy S5", Company = "Samsung", Price = 14000 };
                Phone p2 = new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 8000 };

                db.Phones.Add(p1);
                db.Phones.Add(p2);
                db.SaveChanges();

                foreach (Phone p in db.Phones)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);
                Console.ReadLine();
            }
        }
    }
}
