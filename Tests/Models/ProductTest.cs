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
        private Product CreateNewProductHelper()
        {
            return new Product(
               "Produto",
               "Descrição válida longa",
               100,
               "categoria",
               10,
               new List<string>()
           );
        }

        [Fact]
        public void ShouldCreateNewValidProduct()
        {
            var newProduct = new Product(
              "iPhone 13",
              "Smartphone top com ótima câmera",
               4500,
               "smartphone",
               10,
               new List<string>()

            );

            Assert.Equal("iPhone 13", newProduct.Name);
            Assert.Equal(4500, newProduct.Price);
            Assert.Equal(10, newProduct.Stock);
        }

        [Fact]
        public void ShouldThrowExceptionWhenPriceIsZero()
        {
            Assert.Throws<ArgumentException>(() =>
               new Product(
                   "Produto",
                   "Descrição válida longa",
                   0,
                   "categoria",
                   10,
                   new List<string>()
               )
           );
        }

        [Fact]
        public void ShouldThrowExceptionWhenNameIsTooShort()
        {
            Assert.Throws<ArgumentException>(() =>
                new Product(
                    "ab",
                    "Descrição válida longa",
                    100,
                    "categoria",
                    10,
                    new List<string>()
                )
            );
        }

        [Fact]
        public void ShouldThrowExceptionWhenStockIsNegative()
        {
            Assert.Throws<ArgumentException>(() =>
                new Product(
                    "ab",
                    "Descrição válida longa",
                    100,
                    "categoria",
                    -1,
                    new List<string>()
                )
            );
        }


        [Fact]
        public void ShouldThrowExceptionWhenCategoryIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
                new Product(
                    "ab",
                    "Descrição válida longa",
                    100,
                    "",
                    10,
                    new List<string>()
                )
            );
        }


    }
}