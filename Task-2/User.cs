using System;
using System.Collections.Generic;
using System.Text;

namespace TASK2
{
    class User:IAccount
    {

        private string _fullName;
        private string _email;
        private string _password;

        public User(string email, string fullname)
        {
            this.Email = email;
            this.FullName = fullname;
        
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }
        public string Pass
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }

        public bool PasswordChecker(string Password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;
            if (!string.IsNullOrWhiteSpace(Password) && Password.Length > 7)
            {


                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsDigit(Password[i]))
                    {
                        hasDigit = true;
                    }
                    else if (char.IsUpper(Password[i]))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(Password[i]))
                    {
                        hasLower = true;
                    }
                }

            }
            if (hasDigit == true && hasUpper == true && hasLower == true)

                return true;

            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname - {this.FullName} Email - {this.Email} ");
        }











    }
}
