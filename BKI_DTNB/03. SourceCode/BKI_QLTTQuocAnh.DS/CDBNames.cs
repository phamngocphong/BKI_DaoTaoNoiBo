using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_QLTTQuocAnh.DS.CDBNames

{
    public class V_HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
    }


   

    public class HT_FORM {
        public const string ID =  "ID";
        public const string FORM_NAME =  "FORM_NAME";
        public const string DISPLAY_NAME =  "DISPLAY_NAME";
    }

    public class V_HT_CONTROL_IN_FORM {
        public const string ID =  "ID";
        public const string FORM_NAME =  "FORM_NAME";
        public const string DISPLAY_NAME =  "DISPLAY_NAME";
        public const string CONTROL_NAME =  "CONTROL_NAME";
        public const string CONTROL_TYPE =  "CONTROL_TYPE";
        public const string MA_TU_DIEN =  "MA_TU_DIEN";
        public const string ID_TU_DIEN =  "ID_TU_DIEN";
    }

    
    public enum e_loai_tu_dien
    {
        PHAN_QUYEN = 1
       ,
        DIA_DIEM_QUAN_LY = 2
            ,
        DON_VI_QUAN_LY_CHINH = 3
            ,
        LEVEL_GIANG_VIEN = 4
            ,
        LOAI_HOP_DONG = 5
            ,
        NGANH_DAO_TAO = 6
            ,
        DON_VI_TINH = 7
            ,
        TRANG_THAI_HOP_DONG_KHUNG = 8
            ,
        TRANG_THAI_GIANG_VIEN = 9
            ,
        MA_TAN_SUAT = 10
            ,
        HOC_HAM = 11
            ,
        HOC_VI = 12
            ,
        HINH_THUC_CONG_TAC = 13
            ,
        TRANG_THAI_DOT_THANH_TOAN = 14
            ,
        TRANG_THAI_THANH_TOAN = 15
            ,
        TRANG_THAI_TT_HOP_DONG = 17
            ,
        VAI_TRO_GV = 18
            ,
        LOAI_SU_KIEN = 19
            ,
        TRANG_THAI_SU_KIEN = 20
            ,
        TRANG_THAI_CONG_VIEC_GV = 21
            ,
        TRANG_THAI_HO_SO_GV = 23
            ,
        TRANG_THAI_SU_KIEN_GV = 24
            ,
        LOAI_HO_SO_GV_CM = 25
            ,
        LOAI_HO_SO_GV_HD = 26
            ,
        DV_TO_CHUC_SK = 27
    }

    public class LOAI_TU_DIEN
    {
        public const string PHAN_QUYEN = "PHAN_QUYEN";
        public const string DIA_DIEM_QUAN_LY = "DIA_DIEM_QUAN_LY";
        public const string DON_VI_QUAN_LY_CHINH = "DON_VI_QUAN_LY_CHINH";
        public const string LEVEL_GIANG_VIEN = "LEVEL_GIANG_VIEN";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string TRANG_THAI_HOP_DONG_KHUNG = "TRANG_THAI_HOP_DONG_KHUNG";
        public const string TRANG_THAI_GIANG_VIEN = "TRANG_THAI_GIANG_VIEN";
        public const string HINH_THUC_CONG_TAC = "HINH_THUC_CONG_TAC";
        public const string TRANG_THAI_DOT_THANH_TOAN = "TRANG_THAI_DOT_THANH_TOAN";
        public const string TRANG_THAI_THANH_TOAN = "TRANG_THAI_THANH_TOAN";
        public const string TRANG_THAI_SU_KIEN = "TRANG_THAI_SU_KIEN";
        public const string TRANG_THAI_CONG_VIEC_GV = "TRANG_THAI_CONG_VIEC_GV";
        public const string TRANG_THAI_SU_KIEN_GV = "TRANG_THAI_SU_KIEN_GV";

    }

    public enum e_user_group
    {
        TESTER = 1
        ,
        PM_TD = 2
            ,
        TRUONG_NHOM_PO = 3
            ,
        PO = 4
            ,
        ADMIN = 5
            ,
        GIANG_VIEN = 6
    }


    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }

    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }

    
    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }

    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
    }

    public class HT_CHUC_NANG
    {
        public const string ID = "ID";
        public const string TEN_CHUC_NANG = "TEN_CHUC_NANG";
        public const string URL_FORM = "URL_FORM";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string VI_TRI = "VI_TRI";
        public const string CHUC_NANG_PARENT_ID = "CHUC_NANG_PARENT_ID";
        public const string HIEN_THI_YN = "HIEN_THI_YN";
    }
    public class HT_QUYEN_GROUP
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_USER_GROUP
    {
        public const string ID = "ID";
        public const string USER_GROUP_NAME = "USER_GROUP_NAME";
        public const string DESCRIPTION = "DESCRIPTION";
    }

    public class DM_DAI
    {
        public const string ID = "ID";
        public const string MA_DAI = "MA_DAI";
        public const string TEN_DAI = "TEN_DAI";
    }

    public class DM_DAI_HOC_PHAN
    {
        public const string ID = "ID";
        public const string ID_PHONG_DAI = "ID_PHONG_DAI";
        public const string ID_HOC_PHAN = "ID_HOC_PHAN";
    }

    public class DM_HOC_PHAN
    {
        public const string ID = "ID";
        public const string MA_HOC_PHAN = "MA_HOC_PHAN";
        public const string TEN_HOC_PHAN = "TEN_HOC_PHAN";
        public const string SO_LUONG_YEU_CAU = "SO_LUONG_YEU_CAU";
        public const string BAT_BUOC_YN = "BAT_BUOC_YN";
    }

    public class DM_HOC_PHAN_MON_HOC
    {
        public const string ID = "ID";
        public const string ID_HOC_PHAN = "ID_HOC_PHAN";
        public const string ID_MON_HOC = "ID_MON_HOC";
    }

    public class DM_HOC_PHAN_TIEN_QUYET
    {
        public const string ID = "ID";
        public const string ID_MON_HOC = "ID_MON_HOC";
        public const string ID_MON_HOC_TIEN_QUYET = "ID_MON_HOC_TIEN_QUYET";
    }

    public class DM_MON_HOC
    {
        public const string ID = "ID";
        public const string MA_MON_HOC = "MA_MON_HOC";
        public const string TEN_MON_HOC = "TEN_MON_HOC";
        public const string DON_VI_GIANG_DAY = "DON_VI_GIANG_DAY";
    }

    public class DM_NGACH
    {
        public const string ID = "ID";
        public const string MA_NGACH = "MA_NGACH";
        public const string TEN_NGACH = "TEN_NGACH";
    }

    public class DM_NGACH_DAI
    {
        public const string ID = "ID";
        public const string ID_NGACH = "ID_NGACH";
        public const string ID_DAI = "ID_DAI";
    }

    public class DM_NGACH_PHONG
    {
        public const string ID = "ID";
        public const string KHU_VUC = "KHU_VUC";
        public const string ID_NGACH = "ID_NGACH";
        public const string ID_PHONG = "ID_PHONG";
    }

    public class DM_NGHIEP_VU_MON_HOC
    {
        public const string ID = "ID";
        public const string ID_NGHIEP_VU = "ID_NGHIEP_VU";
        public const string ID_MON_HOC = "ID_MON_HOC";
    }


    public class DM_PHONG_DAI
    {
        public const string ID = "ID";
        public const string ID_PHONG = "ID_PHONG";
        public const string ID_DAI = "ID_DAI";
    }

    public class DM_PHONG_HOC_PHAN
    {
        public const string ID = "ID";
        public const string ID_PHONG = "ID_PHONG";
        public const string ID_HOC_PHAN = "ID_HOC_PHAN";
    }

    public class DM_VERSION_MON_HOC
    {
        public const string ID = "ID";
        public const string ID_MON_HOC = "ID_MON_HOC";
        public const string MA_VERSION = "MA_VERSION";
      
    }

    public class GD_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string ID_GD_DIEM = "ID_GD_DIEM";
        public const string SO_CHUNG_CHI = "SO_CHUNG_CHI";
        public const string NGAY_CAP = "NGAY_BAT_DAU";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }


    public class GD_DIEM
    {
        public const string ID = "ID";
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string DIEM_CHUYEN_CAN = "DIEM_CHUYEN_CAN";
        public const string DIEM_KIEM_TRA = "DIEM_KIEM_TRA";
        public const string DIEM_THI = "DIEM_THI";
        public const string QUA_MON = "QUA_MON";
        public const string HOC_XONG_YN = "HOC_XONG_YN";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";
    }
    public class GD_LOP_MON
    {
        public const string ID = "ID";
        public const string MA_LOP_HOC = "MA_LOP_HOC";
        public const string THOI_GIAN = "THOI_GIAN";
        public const string DIA_DIEM = "DIA_DIEM";
        public const string SO_LUONG = "SO_LUONG";
        public const string ID_VERSION_MON_HOC = "ID_VERSION_MON_HOC";
        public const string DIEM_QUA_MON = "DIEM_QUA_MON";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string NGAY_SUA = "NGAY_SUA";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string NGUOI_SUA = "NGUOI_SUA";
        public const string DA_XOA = "DA_XOA";

    }
    public class V_GD_DIEM
    {
        public const string ID_NHAN_VIEN = "ID_NHAN_VIEN";
        public const string HO_TEN = "HO_TEN";
        public const string MA_TRUNG_TAM = "MA_TRUNG_TAM";
        public const string ID_MON_HOC = "ID_MON_HOC";
        public const string MA_MON_HOC = "MA_MON_HOC";
        public const string MA_LOP_HOC = "MA_LOP_HOC";
        public const string ID_LOP_MON = "ID_LOP_MON";
        public const string ID = "ID";
        public const string DIEM_CHUYEN_CAN = "DIEM_CHUYEN_CAN";
        public const string DIEM_KIEM_TRA = "DIEM_KIEM_TRA";
        public const string DIEM_THI = "DIEM_THI";
        public const string HOC_XONG = "HOC_XONG";
        public const string QUA_MON = "QUA_MON";
        public const string MA_NV = "MA_NV";
        public const string DA_XOA = "DA_XOA";
        public const string TEN_MON_HOC = "TEN_MON_HOC";
        public const string MA_VERSSION = "MA_VERSION";
    }
    public class V_GD_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string NGAY_BAT_DAU = "NGAY_BAT_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string SO_CHUNG_CHI = "SO_CHUNG_CHI";
        public const string TEN_MON_HOC = "TEN_MON_HOC";
        public const string MA_VERSION = "MA_VERSION";
        public const string MA_NV = "MA_NV";
        public const string HO_TEN = "HO_TEN";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string ID_GD_DIEM = "ID_GD_DIEM";
    }


    public class V_HOC_PHAN_MON_HOC
    {
        public const string MA_HOC_PHAN = "MA_HOC_PHAN";
        public const string TEN_HOC_PHAN = "TEN_HOC_PHAN";
        public const string MA_MON_HOC = "MA_MON_HOC";
        public const string TEN_MON_HOC = "TEN_MON_HOC";
    }

    public class V_NGACH_PHONG
    {
        public const string MA_NGACH = "MA_NGACH";
        public const string TEN_NGACH = "TEN_NGACH";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
    }

    public class V_PHONG_DAI
    {
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string MA_DAI = "MA_DAI";
        public const string TEN_DAI = "TEN_DAI";
    }


    public class V_PHONG_HOC_PHAN
    {
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string MA_HOC_PHAN = "MA_HOC_PHAN";
        public const string TEN_HOC_PHAN = "TEN_HOC_PHAN";
    }

    public class V_DAI_HOC_PHAN
    {
        public const string MA_DAI = "MA_DAI";
        public const string TEN_DAI = "TEN_DAI";
        public const string MA_HOC_PHAN = "MA_HOC_PHAN";
        public const string TEN_HOC_PHAN = "TEN_HOC_PHAN";
    }

    public class DM_NHAN_SU_NGHIEP_VU
    {
        public const string ID = "ID";
        public const string ID_NHAN_SU = "ID_NHAN_SU";
        public const string ID_NGHIEP_VU = "ID_NGHIEP_VU";
        public const string NGHIEP_VU_CHINH_YN = "NGHIEP_VU_CHINH_YN";
        public const string NGHIEP_VU_HOC_THEM_YN = "NGHIEP_VU_HOC_THEM_YN";
        public const string DA_XOA_YN = "DA_XOA_YN";
    }

}
