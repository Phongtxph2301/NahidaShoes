using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ADAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChieuCaoDeGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKichCo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KichCo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChieuCaoDeGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCuaHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHangGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHangGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCCCD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaPhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenPhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaQuyDoi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TiLeQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuaChonGiamGia = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoSize = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPhanCap = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheLoai_TheLoai_IdPhanCap",
                        column: x => x.IdPhanCap,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDiemTieuDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoDiem = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemTieuDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiemTieuDung_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChieuCaoDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBan = table.Column<float>(type: "real", nullable: false),
                    GiaNhap = table.Column<float>(type: "real", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGiay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_ChieuCaoDeGiay_IdChieuCaoDeGiay",
                        column: x => x.IdChieuCaoDeGiay,
                        principalTable: "ChieuCaoDeGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Giay_IdGiay",
                        column: x => x.IdGiay,
                        principalTable: "Giay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_HangGiay_IdHangGiay",
                        column: x => x.IdHangGiay,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVienTiepQuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiaoCa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienLai = table.Column<float>(type: "real", nullable: false),
                    TienDuTru = table.Column<float>(type: "real", nullable: false),
                    TienPhatSinh = table.Column<float>(type: "real", nullable: false),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVienTiepQuan",
                        column: x => x.IdNhanVienTiepQuan,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianShip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGia = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSale_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTheLoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTienThanhToan = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietThanhToan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietThanhToan_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietThanhToan_PhuongThucThanhToan_IdPhuongThucThanhToan",
                        column: x => x.IdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichSuDiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiemTieuDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaTriQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDiemTieuDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_DiemTieuDung_IdDiemTieuDung",
                        column: x => x.IdDiemTieuDung,
                        principalTable: "DiemTieuDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_QuyDoi_IdQuyDoi",
                        column: x => x.IdQuyDoi,
                        principalTable: "QuyDoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ChieuCaoDeGiay",
                columns: new[] { "Id", "KichCo", "MaKichCo", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1890371b-eae4-415e-b109-b1c5c0295d3b"), 5, "KC5", 0 },
                    { new Guid("26284e0a-2145-4e3b-bc79-d9863ace5af8"), 2, "KC2", 0 },
                    { new Guid("5332cacb-c80c-4dba-9775-e13dc5fec44d"), 4, "KC4", 0 },
                    { new Guid("6b6a6fe6-5f03-40b3-acf8-c657835a36c4"), 1, "KC1", 0 },
                    { new Guid("ce0a8ca2-4f25-47d0-8513-3e8785fbff86"), 3, "KC3", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("9f3ecec3-270c-4fac-a139-f9b1a48df130"), "CV1", "Nhân viên", 0 });

            migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("adba9553-7e30-4be4-b92c-42886250529c"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0ac64c73-9d9c-47fa-be09-465d6dd635d4"), "G5", "Giày 5", 0 },
                    { new Guid("1c03eb92-3c07-49db-840c-6a942cdf7752"), "G3", "Giày 3", 0 },
                    { new Guid("6ec8c6b9-5cec-40eb-8cef-3159ce219942"), "G4", "Giày 4", 0 },
                    { new Guid("b4af3e2f-0978-4d46-bb60-7992bcb19660"), "G2", "Giày 2", 0 },
                    { new Guid("bff26e25-e1f8-4e10-ab0f-36f342f779ce"), "G1", "Giày 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1ffe9f48-77e3-4177-a06f-fbfbf3e35eb1"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("2b2ef1c5-6bf7-4fcc-82a9-af6ba0ffce90"), "HG2", "Hãng giày 2", 0 },
                    { new Guid("3a9b0667-2e7e-4d7e-8989-6d96877f7da5"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("97a0fdf8-ceb3-40a7-889c-cce236c8af2f"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("9924a157-f5db-4fb8-bf9b-9ad710187559"), "HG5", "Hãng giày 5", 0 }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("31b12342-2f2b-45e2-9fdf-797a132c1639"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 21, 1, 9, 47, 740, DateTimeKind.Local).AddTicks(1695), "0385922775", "01234", "Khách hàng 2", 0 },
                    { new Guid("426c7fcb-9e99-481e-ab08-0dc3dcf56b24"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 21, 1, 9, 47, 740, DateTimeKind.Local).AddTicks(1683), "0385922775", "12345", "Khách hàng 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("478f40ac-15bd-4f70-a461-41536750b535"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("59d7f2ac-bd83-4127-acbe-d4a261ac1168"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("711916ac-7f14-4ee2-8dd2-71959edcbee9"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("cf2bb2e5-b76f-4ea3-822e-1e06c2886544"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("dd8761a5-fe91-40bd-9123-1a201a0efafb"), "MS1", "Màu sắc 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4aeb01bd-b004-46ed-8024-0807679304e3"), "Hà Nội", "NSX2", "Nhà sản xuất 2", 0 },
                    { new Guid("85875dd5-d842-46ab-bfae-5c09c3499c55"), "Hà Nội", "NSX5", "Nhà sản xuất 5", 0 },
                    { new Guid("8f32e82e-e75c-41c2-897b-f817bced0e1a"), "Hà Nội", "NSX1", "Nhà sản xuất 1", 0 },
                    { new Guid("a11f8af2-0580-487b-872b-0a7d15854799"), "Hà Nội", "NSX3", "Nhà sản xuất 3", 0 },
                    { new Guid("c289b0e8-d3a1-46e7-802d-f579eafb5948"), "Hà Nội", "NSX4", "Nhà sản xuất 4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("61e4b30a-3ff2-4a26-b8e3-d6d30824def9"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("95a45356-cda7-4f3c-a45c-7302ef0ee019"), "SZ1", 30, "Size 1", 0 },
                    { new Guid("d8524a33-1a27-4737-baf8-a0c72faf6c44"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("e9860dbb-63f8-45b9-b842-a7bc2c3a9a70"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("edcee84f-8472-4290-9960-55fede4f8ac1"), "SZ5", 34, "Size 5", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("10f1895f-a447-45a7-b44e-10d49efb0c57"), 10000f, 7000f, new Guid("26284e0a-2145-4e3b-bc79-d9863ace5af8"), new Guid("1c03eb92-3c07-49db-840c-6a942cdf7752"), new Guid("1ffe9f48-77e3-4177-a06f-fbfbf3e35eb1"), new Guid("cf2bb2e5-b76f-4ea3-822e-1e06c2886544"), new Guid("a11f8af2-0580-487b-872b-0a7d15854799"), new Guid("edcee84f-8472-4290-9960-55fede4f8ac1"), null, 100, 0 },
                    { new Guid("18d23634-e5cc-4ef6-966a-9ca6b436c351"), 10000f, 7000f, new Guid("26284e0a-2145-4e3b-bc79-d9863ace5af8"), new Guid("bff26e25-e1f8-4e10-ab0f-36f342f779ce"), new Guid("2b2ef1c5-6bf7-4fcc-82a9-af6ba0ffce90"), new Guid("dd8761a5-fe91-40bd-9123-1a201a0efafb"), new Guid("c289b0e8-d3a1-46e7-802d-f579eafb5948"), new Guid("95a45356-cda7-4f3c-a45c-7302ef0ee019"), null, 100, 0 },
                    { new Guid("280c170d-8081-4e04-b9f2-f76d2be0cc78"), 10000f, 7000f, new Guid("ce0a8ca2-4f25-47d0-8513-3e8785fbff86"), new Guid("0ac64c73-9d9c-47fa-be09-465d6dd635d4"), new Guid("9924a157-f5db-4fb8-bf9b-9ad710187559"), new Guid("59d7f2ac-bd83-4127-acbe-d4a261ac1168"), new Guid("85875dd5-d842-46ab-bfae-5c09c3499c55"), new Guid("d8524a33-1a27-4737-baf8-a0c72faf6c44"), null, 100, 0 },
                    { new Guid("28e65567-b027-4268-b05d-8300491c0dee"), 10000f, 7000f, new Guid("ce0a8ca2-4f25-47d0-8513-3e8785fbff86"), new Guid("6ec8c6b9-5cec-40eb-8cef-3159ce219942"), new Guid("1ffe9f48-77e3-4177-a06f-fbfbf3e35eb1"), new Guid("711916ac-7f14-4ee2-8dd2-71959edcbee9"), new Guid("a11f8af2-0580-487b-872b-0a7d15854799"), new Guid("e9860dbb-63f8-45b9-b842-a7bc2c3a9a70"), null, 100, 0 },
                    { new Guid("42a2f8dd-b60e-4195-8fb8-ac3892a42563"), 10000f, 7000f, new Guid("5332cacb-c80c-4dba-9775-e13dc5fec44d"), new Guid("0ac64c73-9d9c-47fa-be09-465d6dd635d4"), new Guid("9924a157-f5db-4fb8-bf9b-9ad710187559"), new Guid("dd8761a5-fe91-40bd-9123-1a201a0efafb"), new Guid("a11f8af2-0580-487b-872b-0a7d15854799"), new Guid("d8524a33-1a27-4737-baf8-a0c72faf6c44"), null, 100, 0 },
                    { new Guid("5ad93586-32ad-4368-bb05-b439ffe8d1c8"), 10000f, 7000f, new Guid("26284e0a-2145-4e3b-bc79-d9863ace5af8"), new Guid("6ec8c6b9-5cec-40eb-8cef-3159ce219942"), new Guid("97a0fdf8-ceb3-40a7-889c-cce236c8af2f"), new Guid("711916ac-7f14-4ee2-8dd2-71959edcbee9"), new Guid("4aeb01bd-b004-46ed-8024-0807679304e3"), new Guid("d8524a33-1a27-4737-baf8-a0c72faf6c44"), null, 100, 0 },
                    { new Guid("85759b32-5653-425f-918b-cc2ed3636075"), 10000f, 7000f, new Guid("6b6a6fe6-5f03-40b3-acf8-c657835a36c4"), new Guid("bff26e25-e1f8-4e10-ab0f-36f342f779ce"), new Guid("2b2ef1c5-6bf7-4fcc-82a9-af6ba0ffce90"), new Guid("dd8761a5-fe91-40bd-9123-1a201a0efafb"), new Guid("8f32e82e-e75c-41c2-897b-f817bced0e1a"), new Guid("95a45356-cda7-4f3c-a45c-7302ef0ee019"), null, 100, 0 },
                    { new Guid("a8a74c0a-12c2-4c5e-9f00-e089eb8c3e04"), 10000f, 7000f, new Guid("26284e0a-2145-4e3b-bc79-d9863ace5af8"), new Guid("0ac64c73-9d9c-47fa-be09-465d6dd635d4"), new Guid("9924a157-f5db-4fb8-bf9b-9ad710187559"), new Guid("478f40ac-15bd-4f70-a461-41536750b535"), new Guid("a11f8af2-0580-487b-872b-0a7d15854799"), new Guid("d8524a33-1a27-4737-baf8-a0c72faf6c44"), null, 100, 0 },
                    { new Guid("a9bc72ba-2b1f-4839-9a66-b1081a7031ef"), 10000f, 7000f, new Guid("6b6a6fe6-5f03-40b3-acf8-c657835a36c4"), new Guid("6ec8c6b9-5cec-40eb-8cef-3159ce219942"), new Guid("1ffe9f48-77e3-4177-a06f-fbfbf3e35eb1"), new Guid("478f40ac-15bd-4f70-a461-41536750b535"), new Guid("8f32e82e-e75c-41c2-897b-f817bced0e1a"), new Guid("edcee84f-8472-4290-9960-55fede4f8ac1"), null, 100, 0 },
                    { new Guid("ecb02ad3-5b05-4fd1-961f-227ff8479005"), 10000f, 7000f, new Guid("6b6a6fe6-5f03-40b3-acf8-c657835a36c4"), new Guid("bff26e25-e1f8-4e10-ab0f-36f342f779ce"), new Guid("3a9b0667-2e7e-4d7e-8989-6d96877f7da5"), new Guid("dd8761a5-fe91-40bd-9123-1a201a0efafb"), new Guid("8f32e82e-e75c-41c2-897b-f817bced0e1a"), new Guid("edcee84f-8472-4290-9960-55fede4f8ac1"), null, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("e25d13ac-47f0-4729-b3c1-6c195d15d493"), "Hà Nội", null, 0, new Guid("9f3ecec3-270c-4fac-a139-f9b1a48df130"), new Guid("adba9553-7e30-4be4-b92c-42886250529c"), "NV1", "00000", new DateTime(2022, 11, 21, 1, 9, 47, 740, DateTimeKind.Local).AddTicks(1646), "0385922775", "Nhân viên 1", 0 },
                    { new Guid("f99ceb5a-bfbc-4ca8-8ba6-07f01de0c578"), "Hà Nội", null, 1, new Guid("9f3ecec3-270c-4fac-a139-f9b1a48df130"), new Guid("adba9553-7e30-4be4-b92c-42886250529c"), "NV2", "00000", new DateTime(2022, 11, 21, 1, 9, 47, 740, DateTimeKind.Local).AddTicks(1669), "0385922775", "Nhân viên 2", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChieuCaoDeGiay_MaKichCo",
                table: "ChieuCaoDeGiay",
                column: "MaKichCo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdChieuCaoDeGiay",
                table: "ChiTietGiay",
                column: "IdChieuCaoDeGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdGiay",
                table: "ChiTietGiay",
                column: "IdGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdHangGiay",
                table: "ChiTietGiay",
                column: "IdHangGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdMauSac_IdSize_IdNsx_IdHangGiay_IdChieuCaoDeGiay_IdGiay",
                table: "ChiTietGiay",
                columns: new[] { "IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdNsx",
                table: "ChiTietGiay",
                column: "IdNsx");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietGiay_IdSale",
                table: "ChiTietSale",
                columns: new[] { "IdChiTietGiay", "IdSale" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdHoaDon",
                table: "ChiTietThanhToan",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdPhuongThucThanhToan",
                table: "ChiTietThanhToan",
                column: "IdPhuongThucThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdChiTietGiay_IdTheLoai",
                table: "ChiTietTheLoai",
                columns: new[] { "IdChiTietGiay", "IdTheLoai" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaChucVu",
                table: "ChucVu",
                column: "MaChucVu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_MaCuaHang",
                table: "CuaHang",
                column: "MaCuaHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_IdKhachHang",
                table: "DiemTieuDung",
                column: "IdKhachHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_MaDiemTieuDung",
                table: "DiemTieuDung",
                column: "MaDiemTieuDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVien",
                table: "GiaoCa",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVienTiepQuan",
                table: "GiaoCa",
                column: "IdNhanVienTiepQuan");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_MaGiaoCa",
                table: "GiaoCa",
                column: "MaGiaoCa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Giay_MaGiay",
                table: "Giay",
                column: "MaGiay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HangGiay_MaHangGiay",
                table: "HangGiay",
                column: "MaHangGiay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietGiay_IdHoaDon",
                table: "HoaDonChiTiet",
                columns: new[] { "IdChiTietGiay", "IdHoaDon" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKhachHang",
                table: "KhachHang",
                column: "MaKhachHang",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_SoCCCD",
                table: "KhachHang",
                column: "SoCCCD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdDiemTieuDung",
                table: "LichSuDiemTieuDung",
                column: "IdDiemTieuDung");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdHoaDon_IdDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                columns: new[] { "IdHoaDon", "IdDiemTieuDung", "IdQuyDoi" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                column: "IdQuyDoi");

            migrationBuilder.CreateIndex(
                name: "IX_MauSac_MaMauSac",
                table: "MauSac",
                column: "MaMauSac",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nsx_MaNsx",
                table: "Nsx",
                column: "MaNsx",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuyDoi_MaQuyDoi",
                table: "QuyDoi",
                column: "MaQuyDoi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_MaGiamGia",
                table: "Sale",
                column: "MaGiamGia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Size_MaSize",
                table: "Size",
                column: "MaSize",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TheLoai_IdPhanCap",
                table: "TheLoai",
                column: "IdPhanCap");

            migrationBuilder.CreateIndex(
                name: "IX_TheLoai_MaTheLoai",
                table: "TheLoai",
                column: "MaTheLoai",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietSale");

            migrationBuilder.DropTable(
                name: "ChiTietThanhToan");

            migrationBuilder.DropTable(
                name: "ChiTietTheLoai");

            migrationBuilder.DropTable(
                name: "GiaoCa");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "LichSuDiemTieuDung");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "ChiTietGiay");

            migrationBuilder.DropTable(
                name: "DiemTieuDung");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "QuyDoi");

            migrationBuilder.DropTable(
                name: "ChieuCaoDeGiay");

            migrationBuilder.DropTable(
                name: "Giay");

            migrationBuilder.DropTable(
                name: "HangGiay");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Nsx");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
