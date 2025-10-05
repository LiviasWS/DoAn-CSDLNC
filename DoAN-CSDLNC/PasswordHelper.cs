using BCrypt.Net;

namespace DoAN_CSDLNC
{
    public static class PasswordHelper
    {
        // Tạo hash từ password gốc
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // So sánh password người dùng nhập với hash trong DB
        public static bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}
