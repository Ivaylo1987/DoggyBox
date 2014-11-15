using DoggyBox.Infrastructure.AutoMapper;
namespace DoggyBox.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings(AutoMapperInitializer automapper)
        {
            automapper.Execute();
        }
    }
}