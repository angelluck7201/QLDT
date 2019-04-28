using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Define
    {
        public static List<T> ListEnum<T>() where T : struct, IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        public static List<string> ListString<T>() where T : struct, IConvertible
        {
            return ListEnum<T>().ConvertAll(s => s.ToString(CultureInfo.InvariantCulture));
        }

        public enum DVTEnum
        {
            Cai,
        }

        public enum LoaiDanhMucEnum
        {
            DienThoai,
            ThuChi
        }

        public enum LoaiKhachHangEnum
        {
            KhachLe,
            KhachSi,
            NhaCungCap,
        }

        public enum LoaiTienTeEnum
        {
            VND,
            USD
        }

        public enum LoaiDonHangEnum
        {
            XuatKho,
            NhapKho,
        }

        public enum ActionTypeEnum
        {
            Close,
        }

        public enum LoaiThongKeEnum
        {
            Ngay,
            Thang,
            Nam,
            Quy
        }

        public enum LoaiThuChiEnum
        {
            Thu,
            Chi,
        }

        public enum PermissionEnum
        {
            None,
            View,
            Write,
        }

        public enum FeatureEnum
        {
            KhoHang,
            XuatKho,
            NhapKho,
            ThuChi,
            TheKho,
            ThongKe,
            NguoiDung,
        }

        public enum LoaiNguoiDung
        {
            Normal,
            Admin
        }

        public enum TrangThaiDonHang
        {
            Moi,
            ThanhToan
        }

        public static Dictionary<FeatureEnum, string> FeatureDict = new Dictionary<FeatureEnum, string>()
        {
            {FeatureEnum.KhoHang, "KHO HÀNG"},
            {FeatureEnum.XuatKho, "XUẤT KHO"},
            {FeatureEnum.NhapKho, "NHẬP KHO"},
            {FeatureEnum.ThuChi, "THU/CHI"},
            {FeatureEnum.TheKho, "THẺ KHO"},
            {FeatureEnum.ThongKe, "THỐNG KÊ"},
            {FeatureEnum.NguoiDung, "NGƯỜI DÙNG"}
        };

        public static Dictionary<string, string> PermissionDict = new Dictionary<string, string>()
        {
            {PermissionEnum.None.ToString(), "KHÔNG CÓ QUYỀN"},
            {PermissionEnum.View.ToString(), "QUYỀN XEM"},
            {PermissionEnum.Write.ToString(), "QUYỀN XEM/TẠO MỚI"}
        };

        public static Dictionary<LoaiKhachHangEnum, string> LoaiKhachHangDict = new Dictionary<LoaiKhachHangEnum, string>()
        {
            {LoaiKhachHangEnum.KhachLe, "KHÁCH LẺ"},
            {LoaiKhachHangEnum.KhachSi, "KHÁCH SỈ"},
            {LoaiKhachHangEnum.NhaCungCap, "NHÀ CUNG CẤP"},
        };

        public static Dictionary<LoaiThuChiEnum, string> LoaiThuChiDict = new Dictionary<LoaiThuChiEnum, string>()
        {
         {LoaiThuChiEnum.Thu, "THU"},
         {LoaiThuChiEnum.Chi, "CHI"}
        };

        public static Dictionary<DVTEnum, string> DVTDict = new Dictionary<DVTEnum, string>()
        {
            {DVTEnum.Cai, "CÁI"},
        };

        public static Dictionary<string, string> LoaiTienTeDict = new Dictionary<string, string>()
        {
            {LoaiTienTeEnum.VND.ToString(), "VND"},
            {LoaiTienTeEnum.USD.ToString(), "USD"}
        };

        public static long KhachLeId = 3;
        public static string DefaultPassword = "123456";

        public static string MESSAGE_RESET_PASS = "Sau khi reset, mật khẩu sẽ được trả về mặt định: 123456";
        public static string MESSAGE_RESET_PASS_TITLE = "Reset mật khẩu";
        public static string MESSAGE_LOCK_USER = "Bạn có chắc muốn khóa/mở khóa tài khoản này?";
        public static string MESSAGE_LOCK_USER_TITLE = "Khóa tài khoản";

        public static string MESSAGE_IN_HOA_DON = "Bạn có muốn in đơn hàng này?";
        public static string MESSAGE_IN_HOA_DON_TITLE = "Thanh toán thành công";
        public static string MESSAGE_XOA_HOA_DON = "Khi xóa đơn hàng, những phần liên quan đến hóa đơn: Công Nợ của hóa đơn, hàng tồn trong kho sẽ được cập nhật lại. Bạn có chắc muốn xóa?";
        public static string MESSAGE_XOA_HOA_DON_TITLE = "Xóa Đơn Hàng";

        public static string MESSAGE_CHOT_HOA_DON = "Bạn có muốn chốt đơn hàng này không? Đơn Hàng sau khi chốt sẽ không thể chỉnh sửa và được lưu thành công nợ(nếu có nợ).";
        public static string MESSAGE_CHOT_HOA_DON_TITLE = "Chốt Đơn Hàng";

        public static string MESSAGE_NGUNG_KINH_DOANH = "Bạn có chắc muốn ngưng kinh doanh {0}?";
        public static string MESSAGE_NGUNG_KINH_DOANH_TITLE = "Xác Nhận";

    }
}
