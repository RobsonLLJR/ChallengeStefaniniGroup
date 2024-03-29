﻿using AutoMapper;
using ChallengeStefaniniGroup.Core.Models;

namespace ChallengeStefaniniGroup.Core
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Domain.Entities.Task, TaskModel>();
            CreateMap<UpdateTaskModel, Domain.Entities.Task>();
        }
    }
}
