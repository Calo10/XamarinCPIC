using System;
namespace ProyectoXamarinCPIC.Model
{
    public class UserModel
    {

        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }


        public UserModel()
        {

        }

        public static bool ValidateUser(string user, string password)
        {

            if (user == "Carlos" && password == "123")
                return true;

            return false;
        }


    }
}
