using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTruongHoc.Models.QuanLyNghiepVu
{
    [Table("KiNang")]
    public class KiNang
    {
        public int Id { get; set; }
        [DisplayName("Tên kĩ năng")]
        public string Name { get; set; }
    }
}
