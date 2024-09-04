using AutoMapper;
using Core.Dto;
using Core.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MapperProfiles
{
    public class AppProfile:Profile
    {
        public AppProfile()
        {
            CreateMap<CreateMercedesModel, Mercedes>();
            CreateMap<MercedesDto, Mercedes>().ReverseMap();
        }
        
    }
}
