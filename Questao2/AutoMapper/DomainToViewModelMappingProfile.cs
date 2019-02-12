using AutoMapper;
using Domain.Entities;
using Questao2.ViewModels;

namespace Questao2.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<SalesOrder, SalesOrderViewModel>();
        }
    }
}