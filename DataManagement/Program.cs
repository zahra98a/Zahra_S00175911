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
                Phone p1 = new Phone(1,"Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");

                Phone p2 = new Phone(2,"iphone 11", 600, "Ios", "/images/apple.png", "/images/iphone11.jpg");

                //adding objects to DB
                db.phones.Add(p1);
                db.phones.Add(p2);

                //just for cheking
                Console.WriteLine("data added");
                // save Database
                db.SaveChanges();

            }
        }
    }
}
