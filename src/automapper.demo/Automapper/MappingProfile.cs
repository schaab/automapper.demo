using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using automapper.demo.service.Models;
using automapper.demo.Models;

namespace automapper.demo.Automapper
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<FooBarDTO, MappingExampleTwo>()
                .ForMember(dest => dest.Foo, opt => opt.MapFrom(src => src.Foo))
                .ForMember(dest => dest.Bar, opt => opt.MapFrom(src => src.Bar));

            Mapper.CreateMap<string, int>().ConvertUsing(Convert.ToInt32);

            Mapper.CreateMap<string, DateTime>().ConvertUsing<DateTimeTypeConverter>();

            Mapper.CreateMap<WidgetDTO, WigetModel>()
                .ForMember(dest => dest.Property1, opt => opt.MapFrom(src => src.Property1))
                .ForMember(dest => dest.Property2, opt => opt.MapFrom(src => src.Property2))
                .ForMember(dest => dest.Property3, opt => opt.Ignore());

        }

        public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
        {
            public DateTime Convert(ResolutionContext context)
            {
                return System.Convert.ToDateTime(context.SourceValue);
            }
        }
    }
}