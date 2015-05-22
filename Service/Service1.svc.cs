using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        BUS.Dang_nhap DN = new BUS.Dang_nhap();
        BUS.Khach_hang Kh = new BUS.Khach_hang();
        BUS.Tai_khoan TK = new BUS.Tai_khoan();
        BUS.Chuyen_tien BCT = new BUS.Chuyen_tien();
        BUS.The_nap_tien TNT = new BUS.The_nap_tien();
        BUS.Nap_tien NT = new BUS.Nap_tien();
        BUS.Ngan_hang NH = new BUS.Ngan_hang();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public int Dang_nhap(string Ten_tai_khoan, string Mat_khau)
        {
            return DN.DN(Ten_tai_khoan, Mat_khau);
        }
        public void Doi_mat_khau(string Ten_dang_nhap, string Mat_khau_moi)
        {
            DN.Doi_mat_khau(Ten_dang_nhap, Mat_khau_moi);
        }
        public DTO.Khach_hang Lay_khach_hang(string Ten_dang_nhap, string Mat_khau)
        {
            return Kh.Lay_khach_hang(Ten_dang_nhap, Mat_khau);
        }
        public string Lay_so_tai_khoan(string Ten_tai_khoan, string Mat_khau)
        {
            return DN.Lay_so_tai_khoan(Ten_tai_khoan, Mat_khau); 
        }
        public double Lay_so_tien(string So_tai_khoan)
        {
            return TK.Lay_so_tien(So_tai_khoan);
        }
        public int Lay_tinh_trang(string So_tai_khoan)
        {
            return TK.Lay_tinh_trang(So_tai_khoan);
        }
        public void Thay_doi_tinh_trang(string So_tai_khoan, int Tinh_trang)
        {
            TK.Thay_doi_tinh_trang(So_tai_khoan, Tinh_trang);
        }
        public void Them_chuyen_tien(DTO.Chuyen_tien CT, string Loai)
        {
            BCT.Them_chuyen_tien(CT, Loai);
        }
        public bool Kiem_tra_tai_khoan(string So_tai_khoan)
        {
            return TK.Kiem_tra_tai_khoan(So_tai_khoan);
        }
        public List<DTO.Chuyen_tien> Ds_chuyen_tien(string Stk_chuyen)
        {
            return BCT.Danh_sach_chuyen(Stk_chuyen);
        }
        public List<DTO.Chuyen_tien> Ds_nhan_tien(string Stk_nhan)
        {
            return BCT.Danh_sach_nhan(Stk_nhan);
        }
        public List<DTO.Chuyen_tien> Ds_chuyen_tien_tong(string So_tai_khoan)
        {
            return BCT.Danh_sach_tong(So_tai_khoan);
        }
        public List<DTO.Chuyen_tien> Danh_sach_theo_ngay(DateTime bd, DateTime kt)
        {
            return BCT.Danh_sach_theo_ngay(bd, kt);
        }
        public void Nap_tien(string So_tai_khoan, double So_tien)
        {
            TK.Nap_tien(So_tai_khoan, So_tien);
        }
        public void Tao_the_nap_tien(double So_tien)
        {
            TNT.Tao_the_nap(So_tien);
        }
        public List<DTO.Nap_tien> Ds_nap_tien(string Stk_nap)
        {
            return NT.Danh_sach_nap(Stk_nap);
        }
        public int Them_nap_tien(DTO.Nap_tien temp, string Ma_code)
        {
            return NT.Them_nap_tien(temp, Ma_code);
        }
        public double Lay_so_tien_the(string Ma_code)
        {
            return TNT.Lay_so_tien(Ma_code);
        }
        public List<DTO.The_nap_tien> Ds_the()
        {
            return TNT.Ds_the();
        }
        public void Tao_the_ngan_hang(double So_tien)
        {
            TNT.Tao_the_ngan_hang(So_tien);
        }
        public string Lay_loai_tai_khoan(string So_tai_khoan)
        {
            return TK.Lay_loai_tai_khoan(So_tai_khoan);
        }
        public void Thay_doi_loai_tai_khoan(string So_tai_khoan, string Loai_tai_khoan)
        {
            TK.Thay_doi_loai_tai_khoan(So_tai_khoan, Loai_tai_khoan);
        }
        public void Rut_tien(string So_tai_khoan, double So_tien)
        {
            TK.Rut_tien(So_tai_khoan, So_tien);
        }
        public string Lay_ten_ngan_hang()
        {
            return NH.Lay_ten_ngan_hang();
        }
        public void Doi_ten_ngan_hang(string ten_moi)
        {
            NH.Doi_ten_ngan_hang(ten_moi);
        }
        public void Them_khach_hang(DTO.Khach_hang khachhang)
        {
            Kh.Them_khach_hang(khachhang);
        }
        public void Thay_doi_khach_hang(DTO.Khach_hang khachhang)
        {
            Kh.Thay_doi_khach_hang(khachhang);
        }
        public List<DTO.Khach_hang> Ds_khach()
        {
            return Kh.Ds_khach_hang();
        }
        public bool Them_tai_khoan(DTO.Tai_khoan Taikhoan, DTO.Dang_nhap dangnhap)
        {
            return TK.Them_tai_khoan(Taikhoan, dangnhap);
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan()
        {
            List<DTO.Tai_khoan> kq = new List<DTO.Tai_khoan>();
            kq = TK.Ds_tai_khoan();
            return kq;
        }
        public string Ma_khach_hang()
        {
            return Kh.Ma_khach_hang();
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan_theo_kh(string Ma_khach_hang)
        {
            return TK.Ds_tai_khoan_theo_kh(Ma_khach_hang);
        }
    }
}
