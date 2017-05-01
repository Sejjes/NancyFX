using Nancy;

namespace NancyEmptyAspNetHost1
{
    public class nan : NancyModule
    {
        public nan()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}