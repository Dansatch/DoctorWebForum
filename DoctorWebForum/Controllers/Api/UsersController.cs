using AutoMapper;
using DoctorWebForum.Dtos;
using DoctorWebForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorWebForum.Controllers.Api
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/users
        public IHttpActionResult GetUsers()
        {
            var usersQuery = _context.Users.ToList();

            var usersDto = usersQuery
                .Select(Mapper.Map<ApplicationUser, ApplicationUserDto>);

            return Ok(usersDto);
        }

        //GET /api/users/user1
        public IHttpActionResult GetUser(string userName)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == userName);

            if (user == null)
                return NotFound();

            return Ok(Mapper.Map<ApplicationUser, ApplicationUserDto>(user));
        }

        //PUT /api/users/1
        [HttpPut]
        public void UpdateUser(string userName, ApplicationUserDto userDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = _context.Users.SingleOrDefault(u => u.UserName == userName);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(userDto, userInDb);

            _context.SaveChanges();
        }

        //DELETE /api/users/1
        [Authorize(Roles = RoleName.CanDeleteUsers)]
        [HttpDelete]
        public void DeleteUser(string userName)
        {
            var userInDb = _context.Users.SingleOrDefault(u => u.UserName == userName);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Users.Remove(userInDb);
            _context.SaveChanges();
        }
    }
}
