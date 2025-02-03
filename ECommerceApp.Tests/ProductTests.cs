using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECommerceApp_Group3;

namespace ECommerceApp.Tests
{
    [TestFixture]
    public class ProductTests
    {
        /// <summary>
        /// This test is testing the ValidProductId method with a valid product ID.
        /// This test ensures that the method correctly identifies a valid product ID within the acceptable range (8 to 80000).
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important test because valid product IDs are the most common use case.
        /// </summary>
        [Test]
        public void ValidProductId_ValidInput_ReturnsValid()
        {
            int validID = 100;
            Product product = new Product(validID, "Pizza", 80.49, 20);

            string expected = "The Product Id is valid.";
            string actual = Product.ValidProductId(validID);

            Assert.That(expected, Is.EqualTo(actual));
        }


        /// <summary>
        /// This test is testing the ValidProductName method with a valid product name.
        /// This test ensures that the method correctly identifies a valid product name containing only letters, digits, and spaces.
        /// 
        /// I chose this test to verify that the method handles valid product names correctly. 
        /// This is important test because product names are a very important part of the application and must meet specific formatting and naming requirements.
        /// </summary>
        [Test]
        public void ValidProductName_AnotherValidInput_ReturnsValid()
        {
            string prodName = "Bottle";
            Product product = new Product(352, prodName, 25.20, 7600);

            string expected = "The Product Name is valid.";
            string actual = Product.ValidProductName(prodName);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidItemPrice method with an invalid item price above the maximum allowed value.
        /// This test ensures that the method correctly identifies an invalid item price that exceeds the maximum limit of $8000.
        /// 
        /// I chose this test to verify that the method handles edge cases correctly. 
        /// This is important test because it ensures that the application prevents users from entering prices that are out of given range.
        /// </summary>
        [Test]
        public void ValidItemPrice_InvalidInputAboveMaximum_ReturnsInvalid()
        {
            double itemPrice = 8300.00;
            Product product = new Product(478, "Bag", itemPrice, 7800);

            string expected = "The Item Price is not valid.";
            string actual = Product.ValidItemPrice(itemPrice);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidStock method with a valid stock amount.
        /// This test ensures that the method correctly identifies a valid stock amount within the acceptable range (8 to 800000).
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important test because valid stock amounts are the most common use case.
        /// </summary>
        [Test]
        public void ValidStock_ValidInput_ReturnsValid()
        {
            int stockAmount = 3500;
            Product product = new Product(478, "BMW M5 CS", 110250, stockAmount);

            string expected = "The Stock Amount is valid.";
            string actual = Product.ValidStock(stockAmount);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidIncreaseStock method with a negative increase amount.
        /// This test ensures that the method correctly identifies an invalid increase amount that is less than or equal to zero.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from entering negative values for stock increases.
        /// </summary>
        [Test]
        public void ValidIncreaseStock_InvalidInputNegativeAmount_ReturnsInvalid()
        {
            int currentStock = 300000;
            int increaseAmount = -1;

            string expected = "Stock increase amount must be greater than zero.";
            string actual = Product.ValidIncreaseStock(currentStock, increaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidDecreaseStock method with a negative decrease amount.
        /// This test ensures that the method correctly identifies an invalid decrease amount that is less than or equal to zero.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from entering negative values for stock decreases, 
        /// as negative stock adjustments are not meaningful in a real-world scenario.
        /// </summary>
        [Test]
        public void ValidDecreaseStock_InvalidInputNegativeAmount_ReturnsInvalid()
        {
            int currentStock = 300000;
            int decreaseAmount = -4;

            string expected = "Stock decrease amount must be greater than zero.";
            string actual = Product.ValidDecreaseStock(currentStock, decreaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidProductId method with an invalid product ID below the minimum allowed value.
        /// This test ensures that the method correctly identifies an invalid product ID that is less than the minimum limit of 8.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important because the application must prevent users from entering product IDs that are too small, 
        /// ensuring that only valid IDs within the specified range are accepted.
        /// </summary>
        [Test]
        public void prodIdTestCaseValidProductId_InvalidInput_ReturnsInvalid3_Invalid()
        {
            int invalidID = 5;
            Product product = new Product(invalidID, "Laptop", 4500.99, 1000);

            string expected = "The Product Id is not valid.";
            string actual = Product.ValidProductId(invalidID);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidProductName method with an invalid product name containing special characters.
        /// This test ensures that the method correctly identifies an invalid product name that includes characters other than letters, digits, and spaces.
        /// 
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must enforce the rule that product names can only contain letters, and spaces, 
        /// ensuring consistency and preventing invalid data entry.
        /// </summary>
        [Test]
        public void ValidProductName_InvalidInput_ReturnsInvalid()
        {
            string prodName = "Mice@81";
            Product product = new Product(478, prodName, 300.10, 1120);

            string expected = "The Product Name is not valid. Product name can only contain letters, digits, and spaces.";
            string actual = Product.ValidProductName(prodName);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidItemPrice method with a valid item price within the acceptable range.
        /// This test ensures that the method correctly identifies a valid item price between the minimum ($8) and maximum ($8000) limits.
        /// 
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important test because valid item prices are the most common use case, and the application must ensure that prices within the specified range are accepted.
        /// </summary>
        [Test]
        public void ValidItemPrice_ValidInput_ReturnsValid()
        {
            double itemPrice = 2300.99;
            Product product = new Product(478, "CPU", itemPrice, 1120);

            string expected = "The Item Price is valid.";
            string actual = Product.ValidItemPrice(itemPrice);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidStock method with an invalid stock amount above the maximum allowed value.
        /// This test ensures that the method correctly identifies an invalid stock amount that exceeds the maximum limit of 800000.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from entering stock amounts that are too high, 
        /// ensuring that only valid stock amounts within the specified range are accepted.
        /// </summary>
        [Test]
        public void ValidStock_InvalidInputAboveMaximum_ReturnsInvalid()
        {
            int stockAmount = 950000;
            Product product = new Product(3456, "Bed", 2800.99, stockAmount);

            string expected = "The Stock Amount is not valid.";
            string actual = Product.ValidStock(stockAmount);

            Assert.That(expected, Is.EqualTo(actual));
        }


        /// <summary>
        /// This test is testing the ValidIncreaseStock method with a valid increase amount.
        /// This test ensures that the method correctly identifies a valid increase amount that does not cause the stock to exceed the maximum limit.
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important test because valid stock increases are a common use case in the application, 
        /// and the system must ensure that such operations are handled correctly.
        /// </summary>
        [Test]
        public void ValidIncreaseStock_ValidInput_ReturnsValid()
        {
            int currentStock = 10;
            int increaseAmount = 50;

            string expected = "Stock increase is valid.";
            string actual = Product.ValidIncreaseStock(currentStock, increaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        // <summary>
        /// This test is testing the ValidDecreaseStock method with a valid decrease amount.
        /// This test ensures that the method correctly identifies a valid decrease amount that does not cause the stock to fall below the minimum limit.
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important test because valid stock decreases are a common use case in the application.
        /// </summary>
        [Test]
        public void ValidDecreaseStock_ValidInput_ReturnsValid()
        {
            int currentStock = 120000;
            int decreaseAmount = 5500;

            string expected = "Stock decrease is valid.";
            string actual = Product.ValidDecreaseStock(currentStock, decreaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidProductId method with another valid product ID within the acceptable range.
        /// This test ensures that the method correctly identifies a valid product ID between the minimum (8) and maximum (80000) limits.
        /// 
        /// I chose this test to verify that the method works as expected for another typical valid input. 
        /// This is important test because it ensures that the application consistently accepts valid product IDs within the specified range.
        /// </summary>
        [Test]
        public void ValidProductId_AnotherValidInput_ReturnsValid()
        {
            int validID = 2345;
            Product product = new Product(validID, "Watch", 1000.29, 600);

            string expected = "The Product Id is valid.";
            string actual = Product.ValidProductId(validID);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidProductName method with a valid product name containing only letters.
        /// This test ensures that the method correctly identifies a valid product name that meets the formatting requirements (letters, digits, and spaces only).
        /// 
        /// I chose this test to verify that the method works as expected for a typical valid input. 
        /// This is important because valid product names are a critical part of the application, and the system must ensure that they are accepted when they meet the required format.
        /// </summary>
        [Test]
        public void ValidProductName_ValidInput_ReturnsValid()
        {
            string prodName = "Phone";
            Product product = new Product(1223, prodName, 1200.39, 800);

            string expected = "The Product Name is valid.";
            string actual = Product.ValidProductName(prodName);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidItemPrice method with an invalid item price below the minimum allowed value.
        /// This test ensures that the method correctly identifies an invalid item price that is less than the minimum limit of $8.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from entering prices that are too low, 
        /// ensuring that only valid prices within the specified range are accepted.
        /// </summary>
        [Test]
        public void ValidItemPrice_InvalidInputBelowMinimum_ReturnsInvalid()
        {
            double itemPrice = 3.99;
            Product product = new Product(478, "Monitor", itemPrice, 200);

            string expected = "The Item Price is not valid.";
            string actual = Product.ValidItemPrice(itemPrice);

            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidIncreaseStock method with an invalid increase amount that exceeds the maximum stock limit.
        /// This test ensures that the method correctly identifies an invalid increase amount that would cause the stock to exceed the maximum limit of 800000.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from increasing stock beyond the maximum allowed limit, 
        /// ensuring that stock levels remain within the specified range.
        /// </summary>
        [Test]
        public void increaseStoValidIncreaseStock_InvalidInputExceedsMaximum_ReturnsInvalidckTestCase2()
        {
            int currentStock = 6660;
            int increaseAmount = 1000000;

            string expected = "Stock amount exceeds maximum stock limit.";
            string actual = Product.ValidIncreaseStock(currentStock, increaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidDecreaseStock method with an invalid decrease amount that would cause the stock to fall below the minimum limit.
        /// This test ensures that the method correctly identifies an invalid decrease amount that would result in stock levels below the minimum limit of 8.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from decreasing stock below the minimum allowed limit, 
        /// ensuring that stock levels remain within the specified range.
        /// </summary>
        [Test]
        public void ValidDecreaseStock_InvalidInputBelowMinimum_ReturnsInvalid()
        {
            int currentStock = 100;
            int decreaseAmount = 110;

            string expected = "Stock amount falls below minimum stock limit.";
            string actual = Product.ValidDecreaseStock(currentStock, decreaseAmount);
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This test is testing the ValidStock method with an invalid stock amount below the minimum allowed value.
        /// This test ensures that the method correctly identifies an invalid stock amount that is below the minimum limit which is 8.
        /// 
        /// I chose this test to verify that the method handles invalid input correctly. 
        /// This is important test because the application must prevent users from entering stock amounts that are too low, 
        /// ensuring that only valid stock amounts within the specified range are accepted.
        /// </summary>
        [Test]
        public void ValidStock_InvalidInputBelowMinimum_ReturnsInvalid()
        {
            int stockAmount = 3;
            Product product = new Product(7234, "Sony Playstation", 750.99, stockAmount);

            string expected = "The Stock Amount is not valid.";
            string actual = Product.ValidStock(stockAmount);

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}

