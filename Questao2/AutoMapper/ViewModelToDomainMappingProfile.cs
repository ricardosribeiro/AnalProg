using AutoMapper;
using Domain.Entities;
using Questao2.ViewModels;

namespace Questao2.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<SalesOrderViewModel, SalesOrder>();
        }
    }
}