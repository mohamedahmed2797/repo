using static repo.ListGenerator;
namespace repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly typed local variable [var , dynamic]
            #region var
            //var Data = "ahmed";
            //Data = 5;
            //Data = null;
            //var x;
            //Data = "May";
            #endregion
            #region dynamic
            // dynamic Data = "ali";
            //dynamic x;
            //Data = 2;
            //Data = true;
            //Data = 3.3;
            //Data = 'A';
            #endregion
            #endregion
            #region linQ
            //List<int> Numbers= new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> OddNumbers = Numbers.Where(x => x % 2 == 1 ).ToList();
            //foreach (int number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion
            #region linQ Syntax
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region fluent

            //List<int>OddNumbers = Enumerable.Where(Numbers , X => X %2 == 1 ).ToList();  
            //    OddNumbers = Numbers.Where(X => X %2 == 1).ToList();
            //    foreach (int number in OddNumbers)
            //    {
            //        Console.WriteLine(number);
            //    } 
            #endregion

            #region Query
            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;
            //foreach (var o in OddNumbers)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #region Immediate Execution
            //var OddNumbers = Numbers.Where(x => x % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16 });
            //foreach (var number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region fluent syntax
            //var result = ProductsList.Where(p => p.UnitsInStock > 0);
            //foreach (var number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion
            #region Query Syntax
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Indexed where
            //var result = ProductsList.Where((P, i) => i < 10 && P.UnitsInStock == 0);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Transformation [Projection]
            //fluent
            //var result = ProductsList.Select(p => new Product() { ProductID = p.ProductID, ProductName = p.ProductName });
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i.ProductID);
            //    Console.WriteLine(i.ProductName);
            //}
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).Select(p => new
            //{
            //    Id = p.ProductID,
            //    Name = p.ProductName,
            //    OldPrice = p.UnitPrice,
            //    NewPrice = p.UnitPrice - (p.UnitsInStock * 0.1m),
            //});
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             select new
            //             {
            //                 Id = p.ProductID,
            //                 Name = p.ProductName,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - (p.UnitsInStock * 0.1m),
            //             };
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //Query
            //var result = from p in ProductsList
            //             select new
            //             {
            //                 ProductId = p.ProductID,
            //                 ProductName = p.ProductName,
            //             };
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Ordering Operators
            //var result = ProductsList.OrderBy(x => x.UnitPrice);
            //result = from p in ProductsList
            //         orderby p.UnitPrice
            //         select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = ProductsList.OrderBy(X => X.UnitPrice);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            //var result = ProductsList.OrderBy(x => x.UnitPrice).ThenByDescending(x => x.UnitsInStock).Reverse();
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //var result = ProductsList.First();
            //result = ProductsList.Last();
            //Console.WriteLine(result?.ProductName ?? "not found");
            //List<Product> TestProduct = new List<Product>();
            //    var result = TestProduct.FirstOrDefault();
            //result = TestProduct.LastOrDefault();
            //Console.WriteLine(result?.ProductName ?? "not found");

            //var result = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select new
            //             {
            //                 p.ProductID,
            //                 p.ProductName,
            //                 p.UnitsInStock,
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregation Operators
            //var result = ProductsList.Max();
            //Console.WriteLine(result);
            //var result = ProductsList.Min(p=> p.ProductName.Length);
            //Console.WriteLine(result);
            //var MinLength = ProductsList.Min( p => p.ProductName.Length);
            //var result = (from p in ProductsList
            //              where p.ProductName.Length == MinLength
            //              select p).FirstOrDefault();
            //Console.WriteLine(result);
            string[] Names = { "Aya", "Omar", "Amr", "Mohamed" };
            var result = Names.Aggregate((Str01 , Str02)=> $"{Str01} {Str02}");
            Console.WriteLine(result);
            #endregion
            #endregion
        }
    }
}
