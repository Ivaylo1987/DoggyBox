using System.Web.Mvc;
namespace DoggyBox.Web.App_Start
{
    public class ViewEnginesConfig
    {
        public static void RegisterRoutes(ViewEngineCollection viewEngines)
        {
            viewEngines.Clear();
            viewEngines.Add(new RazorViewEngine());
        }
    }
}