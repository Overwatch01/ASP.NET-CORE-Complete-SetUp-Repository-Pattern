using System;
using System.Collections.Generic;
using System.Text;
using ApplicationService.Model.ViewModel;
using AutoMapper;
using Core.Models;

namespace ApplicationService.AutoMapper
{
    public class Config : Profile
    {
        public Config()
        {
            CreateMap<Test, TestViewModel>().ReverseMap();
        }
    }
}
