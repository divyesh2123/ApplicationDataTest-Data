using ApplicatinTest.BussinessEnity;
using ApplicatinTest.DataEntity;
using ApplicatinTest.DataEntity.MyEntity;
using AutoMapper;

namespace ApplicationDataTest.Mapping
{
    public class AutomapperRegistration : Profile
    {
        public AutomapperRegistration()
        {
            CreateMap<User, UserViewModal>().ReverseMap();
            CreateMap<CityMaster, CityViewModal>().ReverseMap();
            //CreateMap<BatchInfoViewModal, BatchInfo>().ReverseMap();
        }
    }
}
