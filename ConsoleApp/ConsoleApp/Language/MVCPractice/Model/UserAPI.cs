using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Language.MVCPractice.Dto;

namespace ConsoleApp.Language.MVCPractice.Model
{
    internal class UserAPI
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string Desc;

        public UserAPI(int id, string name, string desc)
        {
            Id = id;
            Name = name;
            Desc = desc;
        }


        public UserDto ToDto()
        {
            return new UserDto(Id, Name, Desc, "");
        }
    }
}
