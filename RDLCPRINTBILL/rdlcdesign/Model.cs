using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace rdlcdesign
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Voucher")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
