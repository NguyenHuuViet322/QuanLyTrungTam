﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyTruongHoc.Models;

#nullable disable

namespace QuanLyTrungTam.Migrations
{
    [DbContext(typeof(QuanLyTruongHocConText))]
    [Migration("20240403094024_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyConNguoi.StudentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLop")
                        .HasColumnType("int");

                    b.Property<string>("danToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("hoTenCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTenMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ngheNghiep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngheNghiepCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngheNghiepMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nienKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiSinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocVien");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyConNguoi.TeacherInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bangCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chuyenMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("danToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("luong")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ngheNghiep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiSinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phanQuyen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GiaoVien");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("Khoi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.DauDiem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<string>("ghiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("heSo")
                        .HasColumnType("real");

                    b.Property<int>("khoi")
                        .HasColumnType("int");

                    b.Property<string>("namHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DauDiem");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.DauDiemLopHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdDauDiem")
                        .HasColumnType("int");

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdLopHoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DauDiemLopHoc");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.GiaoVienKiNang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdKiNang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GiaoVienKiNang");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.GradeProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Diem")
                        .HasColumnType("real");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdKiThi")
                        .HasColumnType("int");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HoSoDiem");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.HoSoDiemDanh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngay")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HoSoDiemDanh");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.KiNang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KiNang");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GhiChu");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.TKB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KhoiHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TKB");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.TKBItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<int>("IdLop")
                        .HasColumnType("int");

                    b.Property<int>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdTKB")
                        .HasColumnType("int");

                    b.Property<string>("day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tietHoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TKBItem");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVien")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("loaiThongBao")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("QuanLyTruongHoc.Models.QuanLyNghiepVu.ThongBaoLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGiaoVienDt")
                        .HasColumnType("int");

                    b.Property<int>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int>("IdThongBao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ThongBaoLopHoc");
                });
#pragma warning restore 612, 618
        }
    }
}
