using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int Dang_nhap(string Ten_tai_khoan, string Mat_khau);
        [OperationContract]
        void Doi_mat_khau(string Ten_dang_nhap, string Mat_khau_moi);
        [OperationContract]
        DTO.Khach_hang Lay_khach_hang(string Ten_dang_nhap, string Mat_khau);
        [OperationContract]
        string Lay_so_tai_khoan(string Ten_tai_khoan, string Mat_khau);
        [OperationContract]
        double Lay_so_tien(string So_tai_khoan);
        [OperationContract]
        int Lay_tinh_trang(string So_tai_khoan);
        [OperationContract]
        void Thay_doi_tinh_trang(string So_tai_khoan, int Tinh_trang);
        [OperationContract]
        void Them_chuyen_tien(DTO.Chuyen_tien CT,string Loai);
        [OperationContract]
        bool Kiem_tra_tai_khoan(string So_tai_khoan);
        [OperationContract]
        List<DTO.Chuyen_tien> Ds_chuyen_tien(string Stk_chuyen);
        [OperationContract]
        List<DTO.Chuyen_tien> Ds_nhan_tien(string Stk_nhan);
        [OperationContract]
        List<DTO.Chuyen_tien> Ds_chuyen_tien_tong(string So_tai_khoan);
        [OperationContract]
        void Nap_tien(string So_tai_khoan, double So_tien);
        [OperationContract]
        void Tao_the_nap_tien(double So_tien);
        [OperationContract]
        List<DTO.Nap_tien> Ds_nap_tien(string Stk_nap);
        [OperationContract]
        int Them_nap_tien(DTO.Nap_tien temp, string Ma_code);
        [OperationContract]
        double Lay_so_tien_the(string Ma_code);
        [OperationContract]
        List<DTO.The_nap_tien> Ds_the();
        [OperationContract]
        void Tao_the_ngan_hang(double So_tien);
        [OperationContract]
        string Lay_loai_tai_khoan(string So_tai_khoan);
        [OperationContract]
        void Thay_doi_loai_tai_khoan(string So_tai_khoan, string Loai_tai_khoan);
        [OperationContract]
        void Rut_tien(string So_tai_khoan, double So_tien);
        [OperationContract]
        string Lay_ten_ngan_hang();
        [OperationContract]
        void Doi_ten_ngan_hang(string ten_moi);
        [OperationContract]
        List<DTO.Chuyen_tien> Danh_sach_theo_ngay(DateTime bd, DateTime kt);
        [OperationContract]
        void Them_khach_hang(DTO.Khach_hang khachhang);
        [OperationContract]
        void Thay_doi_khach_hang(DTO.Khach_hang khachhang);
        [OperationContract]
        List<DTO.Khach_hang> Ds_khach();
        [OperationContract]
        bool Them_tai_khoan(DTO.Tai_khoan Taikhoan, DTO.Dang_nhap dangnhap);
        [OperationContract]
        List<DTO.Tai_khoan> Ds_tai_khoan();
        [OperationContract]
        string Ma_khach_hang();
        [OperationContract]
        List<DTO.Tai_khoan> Ds_tai_khoan_theo_kh(string Ma_khach_hang);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
