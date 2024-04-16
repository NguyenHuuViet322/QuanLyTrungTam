using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTruongHoc.Models.QuanLyNghiepVu
{
    [Table("HoSoDiemDanh")]
    public class HoSoDiemDanh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int IdHocSinh { get; set; }
        public DateTime ngay { get; set; }
    }
}
