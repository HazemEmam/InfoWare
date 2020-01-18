namespace InfoWare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FQA")]
    public partial class FQA
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string FeadBack { get; set; }

        [StringLength(10)]
        public string Reply { get; set; }

        public int UserID { get; set; }

        public int ProductsID { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
