using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zahra_S00175911;
using static Zahra_S00175911.Phone;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");

                Phone p2 = new Phone("iphone 11", 600, "Ios", "/images/apple.png", "/images/iphone11.jpg");

                db.phones.Add(p1);
                db.phones.Add(p2);

                Console.WriteLine("data added");
                db.SaveChanges();

            }
        }
    }
}
