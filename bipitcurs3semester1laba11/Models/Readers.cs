namespace bipitcurs3semester1laba11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Readers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int r_id { get; set; }

        public string r_fio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? r_dt_birth { get; set; }

        [StringLength(50)]
        public string r_passport { get; set; }
    }
}
