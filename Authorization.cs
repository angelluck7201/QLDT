using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Native;

namespace QLDT
{
    public class Authorization
    {
        public static UserAccount LoginUser;
        public static Dictionary<string, string> Permission = new Dictionary<string, string>();

        public static bool CheckLogin(string userName, string passWord)
        {
            LoginUser = CRUD.DbContext.UserAccounts.ToList().FirstOrDefault(s => (bool)s.IsActived && s.TenNguoiDung.ToUpper().Equals(userName.ToUpper()) && s.MatKhau.Equals(passWord));
            if (LoginUser != null)
            {
                var lstPermission = LoginUser.PhanQuyenNguoiDungs.ToList();
                foreach (var phanQuyenNguoiDung in lstPermission)
                {
                    if (!Permission.ContainsKey(phanQuyenNguoiDung.Feature))
                    {
                        Permission.Add(phanQuyenNguoiDung.Feature, phanQuyenNguoiDung.Permission);
                    }
                }
            }
            return LoginUser != null;
        }

        public static bool IsHavePermission(string feature, string permission)
        {
            if (LoginUser.LoaiNguoiDung == Define.LoaiNguoiDung.Admin.ToString()) return true;
            if (Permission.ContainsKey(feature))
            {
                var userPermission = PrimitiveConvert.StringToEnum<Define.PermissionEnum>(Permission[feature]);
                var inputPermission = PrimitiveConvert.StringToEnum<Define.PermissionEnum>(permission);
                return userPermission >= inputPermission;
            }
            return true;
        }
    }
}
