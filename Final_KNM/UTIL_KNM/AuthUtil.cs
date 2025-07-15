
using DTO_KNM;

namespace UTIL_KNM
{
    public class AuthUtil
    {
        public static NhanVien user = null;
        public static bool IsLogin()
        {
            if (user == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.NhanVienID))
            {
                return false;
            }
            return true;
        }
    }
}
