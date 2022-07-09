using System;

namespace Exercise_Inheritance_Polymorphism.Entities {
    class UsedProduct : Product {
        public DateTime ManufacturingDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturingDate) : base(name, price) {
            ManufacturingDate = manufacturingDate;
        }

        public override string PriceTag() {
            return "\n\nPRICES: \n"  
                + Name
                + " (used) US$"
                + Price
                + " Manufacturing Date: "
                + ManufacturingDate.ToString("d");
        }
    }
}
