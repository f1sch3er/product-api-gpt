using Models;

namespace Tests
{
    /*
        nome muito curto
        descrição curta
        preço = 0
        preço negativo
        estoque negativo
        categoria vazia
     
     */
    public class ProductTest
    {
        [Fact]
        public void ShouldCreateNewValidProduct()
        {
            var newProduct = new Product(
              "iPhone 13",
              "Smartphone top com ótima câmera",
               4500,
               "smartphone",
               10,
               []

            );

        }
    }
}