using System.Threading;
using static ASS2.ListGenerators;
namespace ASS2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region Q1
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q2
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((Ar,I)=>Ar.Length<I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region Q1
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Take(1);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q2
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(a => a > Arr[0]).ElementAt(1);

            //    Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Aggregate Operators

            #region Q1

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =Arr.Count(a=>a%2==1);
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = from c in CustomerList
            //             select new
            //             {
            //                 c.CustomerName,
            //                 orders=c.Orders.Count(),
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var result = from c in ProductList
            //             select new
            //             {
            //                 c.Category,
            //                 products = ProductList.Where(p=>p.ProductID== c.ProductID)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region َ4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =Arr.Sum();
            //Console.WriteLine(result);
            #endregion
            var w = File.ReadAllLines("dictionary_english.txt");
            #region Q5
            //Console.WriteLine(w.Sum(x=>x.Length));
            #endregion
            #region Q6
            //var result = w.Min(m => m.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q7
            //var result = w.Max(m => m.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q8
            //var result = w.Average(m => m.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q9
            //var result = ProductList.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region َ10
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    category=p.Key,
            //    chepeistPrice= p.Min(p=>p.UnitPrice) 
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q11
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Min(p => p.UnitPrice)
            //             from p2 in g
            //             where p2.UnitPrice == cheapestPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 Price = p2.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q12
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Max(p => p.UnitPrice)
            //             from p2 in g
            //             where p2.UnitPrice == cheapestPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 Price = p2.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q13
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Max(p => p.UnitPrice)
            //             from p2 in g
            //             where p2.UnitPrice == cheapestPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 Price = p2.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q14
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Average(p => p.UnitPrice)
            //             from p2 in g
            //             where p2.UnitPrice == cheapestPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 Price = p2.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion
            #region LINQ - Ordering Operators
            #region Q1
            //var result = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Q3
            //var result = ProductList.OrderByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result=Arr.OrderBy(x => x.Length).ThenBy(x=> x);
            //foreach(var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Q5
            //        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //        var sortedWords = Arr
            //.OrderBy(word => word.Length)  // الترتيب حسب طول الكلمة
            //.ThenBy(word => word, StringComparer.OrdinalIgnoreCase);  // الترتيب غير الحساس لحالة الأحرف

            //        foreach (var word in sortedWords)
            //        {
            //            Console.WriteLine(word);
            //        }
            #endregion
            #region Q6
            //var result = ProductList.OrderBy(p=>p.Category).OrderByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //    .OrderBy(word => word.Length)  // الترتيب حسب طول الكلمة
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);  // الترتيب التنازلي غير الحساس لحالة الأحرف

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Q8
            //string[] Arr = {"ero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(a => a[1]=='i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ – Transformation Operators

            #region Q1
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(p =>new {
            //   uppercase= p.ToUpper() ,
            //   lowercase= p.ToLower() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var result = ProductList.Select(product => new
            //{
            //    product.ProductName,
            //    Price = product.UnitPrice,  
            //    product.Category
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.Price}, Category: {item.Category}");
            //}

            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var results = Arr.Select((value, index) => new
            //{
            //    Value = value,
            //    InPlace = value == index
            //});

            //Console.WriteLine("Number: In-place?");
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.Value}: {result.InPlace}");
            //}
            #endregion
            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}



            #endregion
            #region Q6
            //var orders = from p in ProductList
            //             select (new
            //             {
            //                 sum=p.ProductID*p.UnitPrice<500,
            //                 p.ProductName
            //             });

            //Console.WriteLine("Orders with total less than 500.00:");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion
            #region Q7
            //var orders = ProductList.Where(order => order.Category.Year >= 1998);

            //Console.WriteLine("Orders made in 1998 or later:");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}
            #endregion
            #region Q8
            //var uniqueCategories = ProductList
            //            .Select(product => product.Category)
            //            .Distinct();

            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion
            #region َQ9
            //var uniqueFirstLetters = ProductList
            //                .Select(product => product.ProductName[0])
            //                .Union(CustomerList.Select(customer => customer.CustomerName[0]))
            //                .Distinct();

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion
            #region Q10
            //var commonFirstLetters = ProductList
            //                .Select(product => product.ProductName[0])
            //                .Intersect(CustomerList.Select(customer => customer.CustomerName[0]));

            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion
            #region Q11
            //var productFirstLetters = ProductList
            //                .Select(product => product.ProductName[0])
            //                .Except(CustomerList.Select(customer => customer.CustomerName[0]));

            //foreach (var letter in productFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion
            #region َ12
            //var productFirstLetters = ProductList
            //                .Select(product => product.ProductName[0])
            //                .Concat(CustomerList.Select(customer => customer.CustomerName[0]));

            //Console.WriteLine("First Letters of Product Names that are not in Customer Names:");
            //foreach (var letter in productFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            //var result = CustomerList.Where(p => p.Region== "Wa").Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //var orders = CustomerList
            //    .Where(customer => customer.Region == "WA")
            //    .SelectMany(customer => customer.Orders)
            //    .Skip(2);

            //Console.WriteLine("All but the first 2 orders from customers in Washington:");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}

            #endregion
            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num, index) => num >= index);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((num, index) => num >= index);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #endregion
            #region LINQ - Quantifiers
            #region Q1
            //bool containsEi = w.Any(word => word.Contains("ei"));

            //Console.WriteLine($"Any word contains 'ei': {containsEi}");
            #endregion
            #region Q2
            //var groupedProducts = ProductList
            //            .GroupBy(product => product.Category)
            //            .Where(group => group.Any(product => product.UnitsInStock == 0))
            //            .Select(group => new
            //            {
            //                Category = group.Key,
            //                Products = group.ToList()
            //            });

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($" - Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion
            #region Q3
            //var groupedProducts = ProductList
            //            .GroupBy(product => product.Category)
            //            .Where(group => group.All(product => product.UnitsInStock > 0))
            //            .Select(group => new
            //            {
            //                Category = group.Key,
            //                Products = group.ToList()
            //            });

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($" - Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion
            #endregion
            #region LINQ – Grouping Operators
            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedNumbers = numbers.GroupBy(n => n % 5);

            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q2
            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");

            //var groupedWords = words.GroupBy(word => word[0]);

            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q3
            //string[] words = { "from", "salt", "earn", "last", "near", "form" };
            //var groupedWords = words.GroupBy(
            //    word => String.Concat(word.OrderBy(c => c))
            //);
            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine($"Group of words with characters: '{group.Key}'");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion


        }
    }
}