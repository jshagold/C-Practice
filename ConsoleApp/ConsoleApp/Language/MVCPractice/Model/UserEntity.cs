using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Language.MVCPractice.Dto;

namespace ConsoleApp.Language.MVCPractice.Model
{
    internal class UserEntity
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string Password;
        public readonly string Desc;

        public UserEntity(int id, string name, string desc, string password)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Password = password;
        }

        public UserDto ToDto()
        {
            return new UserDto(Id, Name, Desc, "");
        }
    }
}
