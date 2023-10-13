namespace RDLCdesign
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoucherDetail")]
    public partial class VoucherDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string PARTICULARS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string MEMO { get; set; }

        [Column("CR.AMOUNT")]
        public int? CR_AMOUNT { get; set; }

        [Column("DR.AMOUNT")]
        public int? DR_AMOUNT { get; set; }
    }
}
