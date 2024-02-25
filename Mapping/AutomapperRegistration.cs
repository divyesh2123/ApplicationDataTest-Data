using ApplicatinTest.BussinessEnity;
using ApplicatinTest.DataEntity;
using AutoMapper;

namespace ApplicationDataTest.Mapping
{
    public class AutomapperRegistration : Profile
    {
        public AutomapperRegistration()
        {
            CreateMap<User, UserViewModal>().ReverseMap();
            CreateMap<CityMaster, CityViewModal>().ReverseMap();
        }
    }
}
