using System;
using System.Collections.Generic;
using System.Text;// These three are the standard for a new class
using Domain_Layer.Entities.Base_Models; // BaseEnitity lives here

namespace Domain_Layer.Entities.Catalog // standard new class
{
    public class Product : BaseEntity// standard new class // Inheriting from BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}