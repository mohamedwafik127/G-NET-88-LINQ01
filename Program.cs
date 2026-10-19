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
    }
}