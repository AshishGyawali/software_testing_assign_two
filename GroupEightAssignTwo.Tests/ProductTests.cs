using NUnit.Framework;

namespace GroupEightAssignTwo.Tests
{
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Test Product", 100m, 10);
        }

        // ProductID Tests
        [TestCase(1)]
        [TestCase(500)]
        [TestCase(1000)]
        public void Set_ProductID_Test(int productId)
        {
            // Arrange
            var expectedProductId = productId;

            // Act
            var product = new Product(productId, "Test Product", 100m, 10);

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(expectedProductId));
        }

        // ProductName Tests
        [TestCase("Product A")]
        [TestCase("Sample Product")]
        [TestCase("Another Product")]
        public void Set_ProductName_Test(string productName)
        {
            // Arrange
            var expectedProductName = productName;

            // Act
            var product = new Product(1, productName, 100m, 10);

            // Assert
            Assert.That(product.ProductName, Is.EqualTo(expectedProductName));
        }

        // Price Tests
        [TestCase(1.0)]
        [TestCase(2500.0)]
        [TestCase(5000.0)]
        public void Set_Price_Test(double price)
        {
            // Arrange
            var expectedPrice = (decimal)price;

            // Act
            var product = new Product(1, "Test Product", expectedPrice, 10);

            // Assert
            Assert.That(product.Price, Is.EqualTo(expectedPrice));
        }

        // Stock Tests
        [TestCase(1)]
        [TestCase(500)]
        [TestCase(1000)]
        public void Set_Stock_Test(int stock)
        {
            // Arrange
            var expectedStock = stock;

            // Act
            var product = new Product(1, "Test Product", 100m, stock);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedStock));
        }

        // IncreaseStock Tests
        [TestCase(1)]
        [TestCase(500)]
        [TestCase(990)]
        public void IncreaseStock_Test(int increaseAmount)
        {
            // Arrange
            var initialStock = _product.Stock;
            var expectedStock = initialStock + increaseAmount;

            // Act
            _product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(expectedStock));
        }

        // DecreaseStock Tests
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void DecreaseStock_Test(int decreaseAmount)
        {
            // Arrange
            var initialStock = _product.Stock;
            var expectedStock = initialStock - decreaseAmount;

            // Act
            _product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(_product.Stock, Is.EqualTo(expectedStock));
        }
    }
}
