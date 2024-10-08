using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //CreateMap<Models.Customer, DTOs.CustomerDto>();
            //CreateMap<DTOs.CustomerDto, Models.Customer>();

            //CreateMap<Models.Customer, DTOs.CustomerDto>().ReverseMap();


            CreateMap<CreditCard, CustomerDto>();

            CreateMap<Models.Customer, DTOs.CustomerDto>().IncludeMembers(x => x.CreditCard)
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.EPosta, opt => opt.MapFrom(x => x.EMail))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.FullName2()));
                //.ForMember(dest => dest.CCNumber, opt => opt.MapFrom(x => x.CreditCard.Number))
                //.ForMember(dest => dest.CCValidDate, opt => opt.MapFrom(x => x.CreditCard.ValidDate));


            

        }
    }
}
