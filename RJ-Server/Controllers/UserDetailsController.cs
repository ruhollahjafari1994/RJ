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

        public UserDetailsController(IUserDetailsRepository uRepo, IMapper mapper)
        {
            _uRepo = uRepo;
            _mapper = mapper;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult GetUserDetails()
        {
            var objList = _uRepo.GetUserDetails();
            var objDto = new List<RJ_Server.Models.Dtos.UserDetailsDto>();
            foreach (RJ_Server.Models.UserDetails obj in objList)
            {
                objDto.Add(_mapper.Map<RJ_Server.Models.Dtos.UserDetailsDto>(obj));//کاربران لیست از نوع کلاس رو اضافه میکنیم به کاربران در لیست دیگه از کلاس با این تفاوت که اگه توی دی تی او باشن اضافه میشن توی این لیست جدید
            }
            return Ok(objDto); // لیستی از جنس کلاس =>userDetails => برمیگردونه با این شرط که توی =>dto  وجود داشته باشن=> 
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("{userDetail?}", Name = "GetUserDetail")]
        public IActionResult GetUserDetail(string userDetail)
        {
            var obj = _uRepo.GetUserDetail(userDetail);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<RJ_Server.Models.Dtos.UserDetailsDto>(obj);
            return Ok(objDto);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult CreateUserDetail([FromBody] RJ_Server.Models.Dtos.UserDetailsDto userDetailsDto)
        {
            if (userDetailsDto == null)
            {
                return BadRequest(ModelState);
            }
            var userDetailsObj = _mapper.Map<RJ_Server.Models.UserDetails>(userDetailsDto);
            if (_uRepo.UserDetailsNameExist(userDetailsObj.Name))
            {
                ModelState.AddModelError("", "The User Exist !");
                return StatusCode(404, ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_uRepo.CreateUserDetails(userDetailsObj))
            {
                ModelState.AddModelError("", $"Somthing Went Wrong When Saving Record {userDetailsObj.Name}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetUserDetail", new { userDetail = userDetailsObj.UserName }, userDetailsObj);
        }


        [HttpPatch()]
        [Route("{userDetail?}", Name = "UpdateUserDetail")]
        public IActionResult UpdateUserDetail(string userDetail, [FromBody] RJ_Server.Models.Dtos.UserDetailsDto userDetailsDto)
        {
            if (userDetailsDto==null || userDetail!= userDetailsDto.UserName)
            {
                return BadRequest(ModelState);
            }
            var userDetailsObj = _mapper.Map<RJ_Server.Models.UserDetails>(userDetailsDto);
            if (!_uRepo.UpadteUserDetails(userDetailsObj))
            {
                ModelState.AddModelError("", $"Somthing Went Wrong When Updating {userDetailsObj.Name}");
                return StatusCode(404, ModelState);
            }
            return CreatedAtRoute("UpdateUserDetail", new { userDetail = userDetailsObj.UserName }, userDetailsObj);
        }

    }
}
