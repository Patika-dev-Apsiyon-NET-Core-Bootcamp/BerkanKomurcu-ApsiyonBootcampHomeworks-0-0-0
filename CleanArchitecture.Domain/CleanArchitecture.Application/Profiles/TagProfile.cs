﻿using AutoMapper;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagViewModel>();
            CreateMap<TagViewModel, Tag>();
        }
           
        
    }
}
