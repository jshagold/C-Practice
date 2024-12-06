using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.MVCPractice.Model;
using Newtonsoft.Json;

namespace ConsoleApp.MVCPractice.Controller
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
