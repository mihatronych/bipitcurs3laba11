namespace bipitcurs3semester1laba11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Outputs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int o_id { get; set; }

        public int R_id { get; set; }

        public int B_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? o_dt_out { get; set; }

        [Column(TypeName = "date")]
        public DateTime? o_dt_in { get; set; }

        [NotMapped]
        public virtual Books Books { get; set; }

        [NotMapped]
        public virtual Readers Readers { get; set; }
    }
}
