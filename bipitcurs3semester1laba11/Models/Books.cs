namespace bipitcurs3semester1laba11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int b_id { get; set; }

        public string b_name { get; set; }

        public string b_author { get; set; }

        [Column(TypeName = "date")]
        public DateTime? b_publ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? b_born { get; set; }
    }
}
