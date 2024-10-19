using DO_AN.DAL; // Đảm bảo rằng namespace này chính xác
using System;

namespace DO_AN.BAL
{
    internal class QuenmatkhauBAL
    {
        private QuenmatkhauDAL dal; // Khai báo dal

        public QuenmatkhauBAL()
        {
            dal = new QuenmatkhauDAL(); // Khởi tạo dal trong constructor
        }

        public bool IsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email không được để trống.", nameof(email));
            }

            return dal.IsEmailExists(email);
        }
    }
}
