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
    }
}
