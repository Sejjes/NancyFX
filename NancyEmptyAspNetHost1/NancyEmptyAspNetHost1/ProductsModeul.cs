using Nancy;

namespace NancyEmptyAspNetHost1
{
    public class ProductsModeul : NancyModule
    {
        public ProductsModeul():base("/products")
        {
            Get["/"] = _ => "Products!";
        }
    }
}