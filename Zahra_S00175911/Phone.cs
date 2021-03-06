﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Zahra_S00175911
{
    public class Phone
    {
        //properties   

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        // public List<Phone> phones { get; set; }

        public void IncreasePrice(decimal percentageValue)
        {
            Price = Price + (percentageValue * Price);
        }

        public override string ToString()
        {
            return string.Format($"{ID} {Name} {Price} {OperatingSystem} {OS_Image} {Phone_Image}");
        }
        public Phone(int id, string name, decimal price, string operatingSystem, string oS_Image, string phone_Image)
        {
            ID = id;
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = oS_Image;
            Phone_Image = phone_Image;
        }


        public class PhoneData : DbContext
        {
            public PhoneData()  { }

            public DbSet<Phone> phones { get; set; }
        }
    }
}
