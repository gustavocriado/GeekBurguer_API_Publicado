using GeekBurguer_Products_Contract.Enums;

namespace GeekBurguer_Products_Contract.DTO
{
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }

    }
}
