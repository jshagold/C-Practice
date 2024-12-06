using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.MVCPractice.Model;

namespace ConsoleApp.MVCPractice.View
{
    internal class UserView
    {
        public void PrintUI(UserEntity user)
        {
            Console.WriteLine($"User Id print : {user.Name}");
        }
    }
}
