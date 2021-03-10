using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HELP_Desk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HELP_Desk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _usermanager;
        private SignInManager<ApplicationUser> _signinmanager;


        //will be injected automatically on that startup class *services.AddIdentityCore*
        public ApplicationUserController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signinmanager)
        {
            _usermanager = usermanager;
            _signinmanager = signinmanager;
        }
        [HttpPost]
        [Route("Register")]
        //POST: api/ApplicationUser/Register
        public async Task<Object> PostApplicationUser(ApplicationUserViewModel model)
        {

            var applicationuser = new ApplicationUser()
            {
                name = model.Name,
                surname = model.Surname,
                Email = model.Email,
                UserName = model.Email
            };

            try
            {
                var result = await _usermanager.CreateAsync(applicationuser, model.Password);
                return Ok(result);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
