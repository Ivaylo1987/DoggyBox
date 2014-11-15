using AutoMapper;
namespace DoggyBox.Infrastructure.AutoMapper
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}