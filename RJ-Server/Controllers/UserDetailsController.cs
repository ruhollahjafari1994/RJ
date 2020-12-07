using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private RJ_Server.Models.Repository.IRepository.IUserDetailsRepository _uRepo;
        private readonly IMapper _mapper;

        public UserDetailsController(RJ_Server.Models.Repository.IRepository.IUserDetailsRepository uRepo , IMapper mapper)
        {
            _uRepo = uRepo;
            _mapper = mapper;
        }
    }
}
