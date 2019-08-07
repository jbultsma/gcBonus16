using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace gcBonus16
{
    class Car
    {
        private string make;
        public string Make
        {
            get
            {
                return make;
            }
        }

        private string model;
        public string Model
        {
            get
            {
                return model;
            }
        }

        private int year;
        public int Year
        {
            get
            {
                return year;
            }
        }              
        
        public double Price { get; set; }

        public Car()
        {                                    
            this.make = "";
            this.model = "";
            this.year = 0;
            this.Price = 0;
        }

        public Car(string make, string model, int year, double price)
        {            
            this.make = make;
            this.model = model;
            this.year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return (this.Make + "\t" + this.Model + "\t" + this.Year + "\t" + this.Price.ToString("C2", CultureInfo.CurrentCulture));
        }

    }
}
