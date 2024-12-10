using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Language.MVCPractice.Model;

namespace ConsoleApp.Language.MVCPractice.Controller
{
    internal class UserRepository
    {

        public void Save(UserEntity user)
        {
            Console.WriteLine($"Save User in DB : {user.Id}");
        }
    }
}
