using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp_Group3
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int prodId, string prodName, double itemPrice, int stockAmount)
        {
            this.ProdId = prodId;
            this.ProdName = prodName;
            this.ItemPrice = itemPrice;
            this.StockAmount = stockAmount;
        }

        public void increaseStock(int amount)
        {
            StockAmount += amount;
        }
        public void decreaseStock(int amount)
        {
            StockAmount -= amount;
        }

        public static string ValidProductId(int prodId)
        {
            if (prodId >= 8 && prodId <= 80000)
            {
                return "The Product Id is valid.";
            }
            else
            {
                return "The Product Id is not valid.";
            }
        }


        public static string ValidProductName(string prodName)
        {
            if (string.IsNullOrWhiteSpace(prodName))
            {
                return "The Product Name cannot be empty.";
            }
            if (!prodName.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                return "The Product Name is not valid. Product name can only contain letters, digits, and spaces.";
            }
            return "The Product Name is valid.";
        }

        public static string ValidItemPrice(double itemPrice)
        {
            if (itemPrice >= 8 && itemPrice <= 8000)
            {
                return "The Item Price is valid.";
            }
            else
            {
                return "The Item Price is not valid.";
            }
        }

        public static string ValidStock(int stockAmount)
        {
            if (stockAmount >= 8 && stockAmount <= 800000)
            {
                return "The Stock Amount is valid.";
            }
            else
            {
                return "The Stock Amount is not valid.";
            }
        }


        public static string ValidIncreaseStock(int currentStock, int increaseAmount)
        {
            if (increaseAmount <= 0)
                return "Stock increase amount must be greater than zero.";
            if (currentStock + increaseAmount > 800000)
                return "Stock amount exceeds maximum stock limit.";
            return "Stock increase is valid.";
        }

        public static string ValidDecreaseStock(int currentStock, int decreaseAmount)
        {
            if (decreaseAmount <= 0)
                return "Stock decrease amount must be greater than zero.";
            if (currentStock - decreaseAmount < 8)
                return "Stock amount falls below minimum stock limit.";
            return "Stock decrease is valid.";
        }
    }
}
