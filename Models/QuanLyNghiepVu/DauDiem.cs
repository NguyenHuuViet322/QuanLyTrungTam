﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTruongHoc.Models.QuanLyNghiepVu
{
    [Table("DauDiem")]
    public class DauDiem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int Id { get; set; }
        [Required]
        [DisplayName("Tên đầu điểm")]
        public string name { get; set; }
        
        [Required]
        [DisplayName("Hệ số")]
        public float heSo { get; set; }

        [Required]
        [DisplayName("Khối")]
        public int khoi { get; set; }

        [Required]
        [DisplayName("Năm")]
        public string namHoc { get; set; }

        [DisplayName("Ghi chú")]
        public string ghiChu { get; set; }

        [Required]
        [DisplayName("Môn học")]        
        public int IdMonHoc { get; set; }
    }
}
