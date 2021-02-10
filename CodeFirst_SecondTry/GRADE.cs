namespace CodeFirst_SecondTry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAHMOUD.GRADE")]
    public partial class GRADE
    {
        [Key]
        public decimal G_ID { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string VALUEE { get; set; }

        [StringLength(255)]
        public string SECTION { get; set; }
    }
}
