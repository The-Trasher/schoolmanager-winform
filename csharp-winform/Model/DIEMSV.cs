namespace csharp_winform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEMSV")]
    public partial class DIEMSV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MSSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAMH { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMH { get; set; }

        public double? DIEMKTLAN1 { get; set; }

        public double? DIEMKTLAN2 { get; set; }

        public double DIEMTHI { get; set; }

        public double DIEMTONGKET { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
