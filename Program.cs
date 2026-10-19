using System.Drawing;
using System.Xml.Linq;
using static HelperClass;
using static LINQ.DataSources.Source;
public class Program
{
    public static void Main(string[] args)
    {

        #region Question_01
        //1. Get all products from the "Seafood" category. Print each product's name and price.

        //var Seafood = ProductList.Where(s => s.Category == "Seafood");

        //foreach (var item in Seafood)
        //{
        //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
        //}
        #endregion

        #region Question_02

        //2. Get a list of only the product names from ProductList. Print each name.

        //var ProductsName = ProductList.Select(s => s.ProductName).ToList();

        //foreach (var item in ProductsName)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Question_03

        //3. Sort all products by UnitPrice (ascending). Print each product's name and price.

        //var Result = ProductList.OrderBy(s => s.UnitPrice);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
        //}
        #endregion

        #region Question_04

        //4. Get all products where UnitPrice is between 10 and 30

        //var Result = ProductList.Where(s => s.UnitPrice > 10 && s.UnitPrice < 30);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Question_05

        //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

        //var Result = ProductList.Where(s => s.UnitsInStock > 0 && s.Category == "Spices & Condiments");

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Question_06
        //6.Create a new anonymous type with three properties:
        //● Name → the product name
        //● Price → the unit price
        //● StockStatus → a string: "Available" if UnitsInStock > 0,
        //otherwise "Out of Stock"
        //● Print the result.

        //var Result = ProductList.Select(s => new
        //{
        //    Name = s.ProductName,
        //    Price = s.UnitPrice,
        //    StockStatus = s.UnitsInStock > 0 ? "Available" : "Out of Stock"
        //});

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
        //}
        #endregion
    }
}