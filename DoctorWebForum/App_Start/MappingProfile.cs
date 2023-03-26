using AutoMapper;
using DoctorWebForum.Dtos;
using DoctorWebForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorWebForum.App_Start
{
    //Used in mapping DTOs and Model classes used for RESTful API services
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUserDto, ApplicationUser>();
            Mapper.CreateMap<ApplicationUser, ApplicationUserDto>();
        }
    }
}