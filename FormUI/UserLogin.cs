using Entities;

namespace FormUI
{
    public class UserLogin
    {
        public static User LoginUser { get; set; }

        public UserLogin(User user)
        {
            LoginUser = user;
        }
    }
}