namespace InfoWare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdersNumber")]
    public partial class OrdersNumber
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string CaseProducts { get; set; }

        public DateTime? DataPlaced { get; set; }

        public DateTime? DataDliverd { get; set; }

        [Required]
        [StringLength(10)]
        public string PayType { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}
