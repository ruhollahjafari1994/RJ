using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.UserMapper
{
    public class UserMappings :Profile
    {
        public UserMappings()
        {
            CreateMap<RJ_Server.Models.UserDetails, RJ_Server.Models.Dtos.UserDetailsDto>().ReverseMap();
        }
    }
}
