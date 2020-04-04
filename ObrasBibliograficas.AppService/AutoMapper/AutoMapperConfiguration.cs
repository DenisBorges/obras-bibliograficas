using AutoMapper;
using ObrasBibliograficas.AppService.ViewModel;
using ObrasBibliograficas.Domain;

namespace ObrasBibliograficas.AppService.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModelMappingProfile());
                ps.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }

    }

    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EntityViewModel, Entity>();
            CreateMap<AutorViewModel, AutorModel>();
        }
    }

    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Entity, EntityViewModel>();
            CreateMap<AutorModel, AutorViewModel>();
        }
    }
}
