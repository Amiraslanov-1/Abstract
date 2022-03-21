using System;

namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullname = "Salam Gaga";
            string email = "CodeAcademy@mail.ru";
          
            User user = new User(email,fullname);
            user.ShowInfo();
        }
    }
}
