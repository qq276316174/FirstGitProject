
namespace ClassLibrary_2
{
    public class Pubcity
    {
        public static string GetCityName()
        {
            return "我来自北京";
        }
        public static ClassLibrary.Models.Person GetClassLibraryName()
        {
            return ClassLibrary.Pub.Get();
        }
    }
}
