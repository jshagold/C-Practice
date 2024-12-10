using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Language.MVCPractice.Model;
using Newtonsoft.Json;

namespace ConsoleApp.Language.MVCPractice.Controller
{
    internal class UserAPIController
    {
        public void PrintAPI(UserAPI user)
        {
            Console.WriteLine($"User를 API로 제공함 : {user.Id}");
            string v = JsonConvert.SerializeObject(user);
            Console.WriteLine(v);
        }
    }
}
