using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTam.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DauDiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    heSo = table.Column<float>(type: "real", nullable: false),
                    khoi = table.Column<int>(type: "int", nullable: false),
                    namHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMonHoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauDiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DauDiemLopHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDauDiem = table.Column<int>(type: "int", nullable: false),
                    IdLopHoc = table.Column<int>(type: "int", nullable: false),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauDiemLopHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GhiChu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhiChu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bangCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phanQuyen = table.Column<int>(type: "int", nullable: false),
                    luong = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    noiSinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    danToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChiThuongTru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVienKiNang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false),
                    IdKiNang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVienKiNang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLop = table.Column<int>(type: "int", nullable: false),
                    hoTenCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTenMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngheNghiepCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngheNghiepMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nienKhoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    noiSinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    danToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChiThuongTru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoSoDiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKiThi = table.Column<int>(type: "int", nullable: false),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    Diem = table.Column<float>(type: "real", nullable: false),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoDiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoSoDiemDanh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    ngay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoDiemDanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KiNang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiNang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Khoi = table.Column<int>(type: "int", nullable: false),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false),
                    loaiThongBao = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongBaoLopHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdThongBao = table.Column<int>(type: "int", nullable: false),
                    IdLopHoc = table.Column<int>(type: "int", nullable: false),
                    IdHocSinh = table.Column<int>(type: "int", nullable: false),
                    IdGiaoVienDt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBaoLopHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TKB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoiHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TKBItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTKB = table.Column<int>(type: "int", nullable: false),
                    IdGiaoVien = table.Column<int>(type: "int", nullable: false),
                    IdMonHoc = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tietHoc = table.Column<int>(type: "int", nullable: false),
                    IdLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TKBItem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DauDiem");

            migrationBuilder.DropTable(
                name: "DauDiemLopHoc");

            migrationBuilder.DropTable(
                name: "GhiChu");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "GiaoVienKiNang");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "HoSoDiem");

            migrationBuilder.DropTable(
                name: "HoSoDiemDanh");

            migrationBuilder.DropTable(
                name: "KiNang");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "ThongBaoLopHoc");

            migrationBuilder.DropTable(
                name: "TKB");

            migrationBuilder.DropTable(
                name: "TKBItem");
        }
    }
}
