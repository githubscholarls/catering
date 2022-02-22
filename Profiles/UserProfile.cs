using AutoMapper;
using catering.ModelDto;
using catering.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<user, LoginUserDto>();
            CreateMap<RegisterUserDto, user>()
                .ForMember(dest=>dest.UserName,opt=>opt.MapFrom(src=>src.Name))
                .ForMember(dest=>dest.PhoneNumber,opt=>opt.MapFrom(src=>src.Phone))
                .ForMember(dest=>dest.PasswordHash,opt=>opt.MapFrom(src=>src.Password))
                .ForMember(dest=>dest.Email,opt=>opt.MapFrom(src=>src.Email))
                .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.Release.HasValue?DateTime.Now.Year-src.Release.Value.Year:0))
                .ForMember(dest=>dest.DateOfBirth,opt=>opt.MapFrom(src=>src.Release));
        }
    }
}
