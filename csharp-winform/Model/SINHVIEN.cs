namespace csharp_winform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            DIEMSVs = new HashSet<DIEMSV>();
        }

        [Key]
        [StringLength(50)]
        public string MSSV { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        [Required]
        [StringLength(50)]
        public string MALOP { get; set; }

        public int? KHOAHOC { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public double? DIEMTB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEMSV> DIEMSVs { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
