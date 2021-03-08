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
        private SignInManager<ApplicationUser> _signmanager;


        //will be injected automatically on that startup class *AddIdentityCore*
        public ApplicationUserController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signmanager)
        {
            _usermanager = usermanager;
            _signmanager = signmanager;
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
                UserName = model.UserName,
                Email = model.Email
                
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
