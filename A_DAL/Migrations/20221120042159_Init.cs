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
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { new Guid("1573e511-2bf6-46f1-9cab-b26b32d7873b"), 1, "KC1", 0 },
                    { new Guid("22f93609-7718-4f0c-b584-814b519fbfb0"), 3, "KC3", 0 },
                    { new Guid("691819a2-19fe-43d8-af21-0ed0cf4b59f6"), 5, "KC5", 0 },
                    { new Guid("972c46e9-54fc-440a-afff-302806240b83"), 2, "KC2", 0 },
                    { new Guid("a8a9c81c-a708-450f-8cde-870a7c3b6a9b"), 4, "KC4", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("ec70e2b5-33d7-4b5c-8ca7-25bf3c0e9491"), "CV1", "Nhân viên", 0 });

            migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("eea6af0b-4d05-4511-b2d8-f57c01ed92df"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0ab19287-667a-4f66-924e-1d79058cc040"), "G4", "Giày 4", 0 },
                    { new Guid("67caced3-38cf-4b50-80e9-60b8764917ba"), "G2", "Giày 2", 0 },
                    { new Guid("71354bdd-9b6e-4c28-b6d0-b0a7d6eaa633"), "G1", "Giày 1", 0 },
                    { new Guid("a785255a-272c-4b25-99f4-4c0d956f1037"), "G3", "Giày 3", 0 },
                    { new Guid("cca6d03e-fe0e-4a74-9020-f443a885ca3b"), "G5", "Giày 5", 0 }
                });

            migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4167295e-c464-44b1-8d58-7875f18b6e22"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("564e07b5-3a3c-494a-bd08-c02274620c16"), "HG5", "Hãng giày 5", 0 },
                    { new Guid("57b0b8a4-f27f-4136-8599-ece57d55f24d"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("6e0457e1-d2a5-44f2-a389-0a8452642732"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("a897db2e-3522-4dd0-9d2c-82d2a22854d4"), "HG2", "Hãng giày 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("5b0d9e3d-f80f-4def-bec3-e3eed69836b3"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 20, 11, 21, 59, 232, DateTimeKind.Local).AddTicks(4032), "0385922775", "12345", "Khách hàng 1", 0 },
                    { new Guid("809d7f2d-4c9e-4723-990e-0541405ada34"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 20, 11, 21, 59, 232, DateTimeKind.Local).AddTicks(4043), "0385922775", "01234", "Khách hàng 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("20735fbd-5d77-41ea-9289-95b596e3c104"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("3a28c538-ceb9-4101-b399-9b5ef2067f01"), "MS3", "Màu sắc 3", 0 },
                    { new Guid("5aa0317c-c57a-4c76-b2e0-6f82bccbacb7"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("9c6199c1-6722-453f-9145-ae671b277f4e"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("d8d55ff9-9e62-4120-87d7-9729e5b81b53"), "MS1", "Màu sắc 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx" },
                values: new object[,]
                {
                    { new Guid("0024cd42-0cf7-4241-84c3-fe16caaa7015"), "Hà Nội", "NSX1", "Nhà sản xuất 1" },
                    { new Guid("3d51ea05-f362-4856-a2fd-f24b5a50d400"), "Hà Nội", "NSX2", "Nhà sản xuất 2" },
                    { new Guid("4b9a98ef-9047-47b7-a2db-0d28954b3c5e"), "Hà Nội", "NSX3", "Nhà sản xuất 3" },
                    { new Guid("76bf17e0-70df-4f41-8115-bd1a9ba7cb72"), "Hà Nội", "NSX5", "Nhà sản xuất 5" },
                    { new Guid("ee18dcb1-2d00-4fed-a08e-79f47c369f50"), "Hà Nội", "NSX4", "Nhà sản xuất 4" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("5ee50743-f47a-48a0-8aae-30b5b2814bf9"), "SZ5", 34, "Size 5", 0 },
                    { new Guid("63450dc6-dfa7-4efe-8ca3-eabead1adc76"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("7276e0bf-9917-4a45-990d-e9d559627486"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("b5b34e81-cad0-4bcf-a99d-8fc7c62dd21b"), "SZ3", 32, "Size 3", 0 },
                    { new Guid("ddbbea6f-579e-4972-b428-48a50d37c06f"), "SZ1", 30, "Size 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2821771c-2d76-4d08-aa11-7b49e8084cee"), 10000f, 7000f, new Guid("1573e511-2bf6-46f1-9cab-b26b32d7873b"), new Guid("71354bdd-9b6e-4c28-b6d0-b0a7d6eaa633"), new Guid("57b0b8a4-f27f-4136-8599-ece57d55f24d"), new Guid("d8d55ff9-9e62-4120-87d7-9729e5b81b53"), new Guid("4b9a98ef-9047-47b7-a2db-0d28954b3c5e"), new Guid("7276e0bf-9917-4a45-990d-e9d559627486"), null, 100, 0 },
                    { new Guid("31f28f17-5554-4aaa-afab-aa91c10cad2b"), 10000f, 7000f, new Guid("a8a9c81c-a708-450f-8cde-870a7c3b6a9b"), new Guid("67caced3-38cf-4b50-80e9-60b8764917ba"), new Guid("564e07b5-3a3c-494a-bd08-c02274620c16"), new Guid("5aa0317c-c57a-4c76-b2e0-6f82bccbacb7"), new Guid("3d51ea05-f362-4856-a2fd-f24b5a50d400"), new Guid("ddbbea6f-579e-4972-b428-48a50d37c06f"), null, 100, 0 },
                    { new Guid("4120af14-39fe-40cf-9014-b30b6b32814f"), 10000f, 7000f, new Guid("972c46e9-54fc-440a-afff-302806240b83"), new Guid("a785255a-272c-4b25-99f4-4c0d956f1037"), new Guid("a897db2e-3522-4dd0-9d2c-82d2a22854d4"), new Guid("5aa0317c-c57a-4c76-b2e0-6f82bccbacb7"), new Guid("3d51ea05-f362-4856-a2fd-f24b5a50d400"), new Guid("7276e0bf-9917-4a45-990d-e9d559627486"), null, 100, 0 },
                    { new Guid("46d0d24b-a4fd-4088-92d8-10ce58d23d10"), 10000f, 7000f, new Guid("1573e511-2bf6-46f1-9cab-b26b32d7873b"), new Guid("67caced3-38cf-4b50-80e9-60b8764917ba"), new Guid("4167295e-c464-44b1-8d58-7875f18b6e22"), new Guid("9c6199c1-6722-453f-9145-ae671b277f4e"), new Guid("ee18dcb1-2d00-4fed-a08e-79f47c369f50"), new Guid("5ee50743-f47a-48a0-8aae-30b5b2814bf9"), null, 100, 0 },
                    { new Guid("4c6119d7-cfc6-4d7b-85e9-b8f9f10d2491"), 10000f, 7000f, new Guid("22f93609-7718-4f0c-b584-814b519fbfb0"), new Guid("71354bdd-9b6e-4c28-b6d0-b0a7d6eaa633"), new Guid("a897db2e-3522-4dd0-9d2c-82d2a22854d4"), new Guid("20735fbd-5d77-41ea-9289-95b596e3c104"), new Guid("3d51ea05-f362-4856-a2fd-f24b5a50d400"), new Guid("63450dc6-dfa7-4efe-8ca3-eabead1adc76"), null, 100, 0 },
                    { new Guid("6be6c97b-59f8-42dd-9bb0-d1b760ff9eb9"), 10000f, 7000f, new Guid("22f93609-7718-4f0c-b584-814b519fbfb0"), new Guid("a785255a-272c-4b25-99f4-4c0d956f1037"), new Guid("6e0457e1-d2a5-44f2-a389-0a8452642732"), new Guid("9c6199c1-6722-453f-9145-ae671b277f4e"), new Guid("ee18dcb1-2d00-4fed-a08e-79f47c369f50"), new Guid("ddbbea6f-579e-4972-b428-48a50d37c06f"), null, 100, 0 },
                    { new Guid("b9b60074-5893-498a-9c0a-d00c6afaddb2"), 10000f, 7000f, new Guid("22f93609-7718-4f0c-b584-814b519fbfb0"), new Guid("67caced3-38cf-4b50-80e9-60b8764917ba"), new Guid("6e0457e1-d2a5-44f2-a389-0a8452642732"), new Guid("5aa0317c-c57a-4c76-b2e0-6f82bccbacb7"), new Guid("0024cd42-0cf7-4241-84c3-fe16caaa7015"), new Guid("b5b34e81-cad0-4bcf-a99d-8fc7c62dd21b"), null, 100, 0 },
                    { new Guid("c192e034-83de-435d-8535-b2d1ff1e170d"), 10000f, 7000f, new Guid("1573e511-2bf6-46f1-9cab-b26b32d7873b"), new Guid("0ab19287-667a-4f66-924e-1d79058cc040"), new Guid("a897db2e-3522-4dd0-9d2c-82d2a22854d4"), new Guid("5aa0317c-c57a-4c76-b2e0-6f82bccbacb7"), new Guid("ee18dcb1-2d00-4fed-a08e-79f47c369f50"), new Guid("ddbbea6f-579e-4972-b428-48a50d37c06f"), null, 100, 0 },
                    { new Guid("dac4eba3-bc96-4b67-add6-0d09d59bf553"), 10000f, 7000f, new Guid("1573e511-2bf6-46f1-9cab-b26b32d7873b"), new Guid("71354bdd-9b6e-4c28-b6d0-b0a7d6eaa633"), new Guid("564e07b5-3a3c-494a-bd08-c02274620c16"), new Guid("9c6199c1-6722-453f-9145-ae671b277f4e"), new Guid("4b9a98ef-9047-47b7-a2db-0d28954b3c5e"), new Guid("7276e0bf-9917-4a45-990d-e9d559627486"), null, 100, 0 },
                    { new Guid("fbbf48ff-7a14-4fb6-acbe-53a09b67accd"), 10000f, 7000f, new Guid("691819a2-19fe-43d8-af21-0ed0cf4b59f6"), new Guid("71354bdd-9b6e-4c28-b6d0-b0a7d6eaa633"), new Guid("564e07b5-3a3c-494a-bd08-c02274620c16"), new Guid("9c6199c1-6722-453f-9145-ae671b277f4e"), new Guid("3d51ea05-f362-4856-a2fd-f24b5a50d400"), new Guid("7276e0bf-9917-4a45-990d-e9d559627486"), null, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("61152d58-324a-4662-ad6d-83fa08ef22b2"), "Hà Nội", null, 0, new Guid("ec70e2b5-33d7-4b5c-8ca7-25bf3c0e9491"), new Guid("eea6af0b-4d05-4511-b2d8-f57c01ed92df"), "NV1", "00000", new DateTime(2022, 11, 20, 11, 21, 59, 232, DateTimeKind.Local).AddTicks(3985), "0385922775", "Nhân viên 1", 0 },
                    { new Guid("b9e5141c-e8c3-487a-b9d1-c84068bb3d83"), "Hà Nội", null, 1, new Guid("ec70e2b5-33d7-4b5c-8ca7-25bf3c0e9491"), new Guid("eea6af0b-4d05-4511-b2d8-f57c01ed92df"), "NV2", "00000", new DateTime(2022, 11, 20, 11, 21, 59, 232, DateTimeKind.Local).AddTicks(4013), "0385922775", "Nhân viên 2", 0 }
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
