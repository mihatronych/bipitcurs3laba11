namespace bipitcurs3semester1laba11.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Journal : DbContext
    {
        public Journal()
            : base("name=epiclibrary")
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Outputs> Outputs { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
