using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.Services;
using SWP391_BL3W.Helper.Util;
using SWP391_BL3W.DTO;
using SWP391_BL3W.Services.Interface;
namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly UserService userService;
        private readonly Util util;
        public AuthenController(UserService userService, Util util)
        {
            this.userService = userService;
            this.util = util;
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInDTO dto)
        {
            //try
            //{
            //    var result = await userService.SignIn(dto.Email, dto.Password);

            //    if (result == null)
            //    {
            //        return Ok("Unauthenticated"); ;
            //    }
            //    return Ok(result);
            //}
            //catch (Exception ex)
            //{
            //    return Ok(ex);
            //}         
                var response = await userService.SignIn(dto.Email, dto.Password);
                return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
            
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpDTO user)
        {
            try
            {
                user.HashPassword = util.hashPassword(user.HashPassword);
                //await user.SignUp(user);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
