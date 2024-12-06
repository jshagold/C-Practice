using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.MVCPractice.Model;

namespace ConsoleApp.MVCPractice.Dto
{

    internal class UserDto
    {

        public readonly int Id;
        public readonly string Name;
        public readonly string Desc;
        public readonly string Passwd;

        public UserDto(int id, string name, string desc, string passwd)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Passwd = passwd;
        }

        public UserEntity ToEntity()
        {
            return new UserEntity(id: Id, name: Name, desc: Desc, password: Passwd);
        }

        public UserAPI ToAPI()
        {
            return new UserAPI(id: Id, name: Name, desc: Desc);
        }
    }
}
