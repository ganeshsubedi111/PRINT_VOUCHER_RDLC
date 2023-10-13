using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCdesign
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Voucher")
        {
        }

        public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VoucherDetail>()
                .Property(e => e.PARTICULARS)
                .IsUnicode(false);

            modelBuilder.Entity<VoucherDetail>()
                .Property(e => e.MEMO)
                .IsUnicode(false);
        }
    }
}
