namespace NguyenHoangThai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [Key]
        [StringLength(5)]
        public string MaHS { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public virtual Diem Diem { get; set; }
    }
}
