using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.MVCPractice.Model;
using ConsoleApp.MVCPractice.View;

namespace ConsoleApp.MVCPractice.Controller
{
    internal class UserController
    {
        public void PrintWindow()
        {
            UserEntity user = new UserEntity(123, "JJin", "employee", password: "qwer");

            UserView userView = new UserView();
            userView.PrintUI(user);
        }
    }
}
