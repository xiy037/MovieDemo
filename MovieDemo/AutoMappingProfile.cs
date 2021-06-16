using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MovieApplication.Models;

namespace MovieApplication
{
    public class AutoMappingProfile: Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<MovieRequest, Movie>();
        }
    }
}
