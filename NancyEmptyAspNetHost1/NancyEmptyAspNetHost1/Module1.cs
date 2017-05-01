using Nancy;

namespace NancyEmptyAspNetHost1
{
    public class Module1 : NancyModule
    {
        public Module1()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}