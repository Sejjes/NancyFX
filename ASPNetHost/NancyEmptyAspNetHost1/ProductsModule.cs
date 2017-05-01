using Nancy;

namespace NancyEmptyAspNetHost1
{
    public class ProductsModule : NancyModule
    {
        public ProductsModule():base("/products")
        {
            Get["/"] = _ => "Products";

        }
    }
}