using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTruongHoc.Models.QuanLyNghiepVu
{
    [Table("GiaoVienKiNang")]
    public class GiaoVienKiNang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int IdGiaoVien { get; set; }
        public int IdKiNang { get; set; }
    }
}
