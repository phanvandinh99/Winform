namespace NguyenHoangThai.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        [Key]
        [StringLength(5)]
        public string MaHS { get; set; }

        public Double? Toan { get; set; }

        public Double? Ly { get; set; }

        public Double? Hoa { get; set; }

        public Double? DTB { get; set; }

        public virtual HocSinh HocSinh { get; set; }
    }
}
