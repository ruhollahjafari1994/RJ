using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using RJ_Server.Models.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : Controller
    {
        private IUserDetailsRepository _uRepo;
        private readonly IMapper _mapper;

        public UserDetailsController(IUserDetailsRepository uRepo , IMapper mapper)
        {
            _uRepo = uRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var objList = _uRepo.GetUserDetails();
            var objDto = new List<RJ_Server.Models.UserDetails>();
            foreach (RJ_Server.Models.UserDetails obj in objList)
            {
                objDto.Add(_mapper.Map<RJ_Server.Models.UserDetails>(obj));//کاربران لیست از نوع کلاس رو اضافه میکنیم به کاربران در لیست دیگه از کلاس با این تفاوت که اگه توی دی تی او باشن اضافه میشن توی این لیست جدید
            }
            return Ok(objDto); // لیستی از جنس کلاس =>userDetails => برمیگردونه با این شرط که توی =>dto  وجود داشته باشن=> 
        }
    }
}
