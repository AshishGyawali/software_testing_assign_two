namespace GroupEightAssignTwo.nUnitTest
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void ProductID_ValidID_ShouldSetCorrectly()
        {
            // Arrange
            int expectedProductID = 1;

            // Act
            Product product = new Product(1, "Test Product", 100m, 10);

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(expectedProductID));
        }

        [Test]
        public void ProductID_InvalidID_ShouldThrowException()
        {
            // Arrange
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(0, "Test Product", 100m, 10));
        }

        [Test]
        public void ProductName_ValidName_ShouldSetCorrectly()
        {
            // Arrange
            string expectedProductName = "Test Product";

            // Act
            Product product = new Product(1, expectedProductName, 100m, 10);

            // Assert
            Assert.That(product.ProductName, Is.EqualTo(expectedProductName));
        }

        [Test]
        public void Price_ValidPrice_ShouldSetCorrectly()
        {
            // Arrange
            decimal expectedPrice = 100m;

            // Act
            Product product = new Product(1, "Test Product", expectedPrice, 10);

            // Assert
            Assert.That(product.Price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Stock_ValidStock_ShouldSetCorrectly()
        {
            // Arrange
            int expectedStock = 10;

            // Act
            Product product = new Product(1, "Test Product", 100m, expectedStock);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100m, 10);
            int increaseAmount = 5;
            int expectedStock = 15;

            // Act
            product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100m, 10);
            int decreaseAmount = 5;
            int expectedStock = 5;

            // Act
            product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedStock));
        }

        [Test]
        public void IncreaseStock_InvalidAmount_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100m, 10);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.IncreaseStock(-1));
        }

        [Test]
        public void DecreaseStock_InvalidAmount_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100m, 10);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.DecreaseStock(11));
        }

    }
}
