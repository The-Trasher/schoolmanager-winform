namespace csharp_winform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIANGVIEN")]
    public partial class GIANGVIEN
    {
        [Key]
        [StringLength(10)]
        public string MaGV { get; set; }

        [StringLength(30)]
        public string TenGV { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhanLoaiGV { get; set; }

        public bool? Anh { get; set; }
    }
}
