namespace InfoWare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string PNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string Specs { get; set; }

        [Required]
        [StringLength(10)]
        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantitly { get; set; }

        public double? Offer { get; set; }

        public int BrandID { get; set; }

        public int MainCategoryID { get; set; }

        public int SubCategoryID { get; set; }

        public int SubSubCategoryID { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual FQA FQA { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual SubSubCategory SubSubCategory { get; set; }
    }
}
