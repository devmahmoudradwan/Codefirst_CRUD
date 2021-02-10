namespace CodeFirst_SecondTry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAHMOUD.STUDENT")]
    public partial class STUDENT
    {
        public decimal ID { get; set; }

        [StringLength(255)]
        public string FIRSTNAME { get; set; }

        [StringLength(255)]
        public string LASTNAME { get; set; }

        [StringLength(255)]
        public string ADDRESS { get; set; }

        [StringLength(255)]
        public string CITY { get; set; }
    }
}
