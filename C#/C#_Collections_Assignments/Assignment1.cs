namespace C__Collections_Assignments
{
    internal class Assignment1
    {


        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Price: {Price}, Category: {Category}";
            }
        }

        class Program
        {
            static void Main()
            {
                List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000, Category = "Electronics" },
            new Product { Id = 2, Name = "Smartphone", Price = 15000, Category = "Electronics" },
            new Product { Id = 3, Name = "Shoes", Price = 1200, Category = "Fashion" },
            new Product { Id = 4, Name = "Watch", Price = 2500, Category = "Fashion" },
            new Product { Id = 5, Name = "Headphones", Price = 800, Category = "Electronics" },
            new Product { Id = 6, Name = "Book", Price = 500, Category = "Education" },
            new Product { Id = 7, Name = "Tablet", Price = 20000, Category = "Electronics" },
            new Product { Id = 8, Name = "Bag", Price = 900, Category = "Fashion" },
            new Product { Id = 9, Name = "Camera", Price = 30000, Category = "Electronics" },
            new Product { Id = 10, Name = "Pen", Price = 50, Category = "Education" }
        };

                Console.WriteLine("--- All Products ---");
                foreach (var p in products)
                    Console.WriteLine(p);

                Console.WriteLine("\n--- Products with Price > 1000 ---");
                foreach (var p in products.Where(p => p.Price > 1000))
                    Console.WriteLine(p);

                Console.WriteLine("\n--- Products Sorted by Price (Ascending) ---");
                foreach (var p in products.OrderBy(p => p.Price))
                    Console.WriteLine(p);

                Console.WriteLine("\n--- Products Sorted by Price (Descending) ---");
                foreach (var p in products.OrderByDescending(p => p.Price))
                    Console.WriteLine(p);

                Console.WriteLine("\n--- Remove Product by Id (3) ---");
                products.RemoveAll(p => p.Id == 3);
                foreach (var p in products)
                    Console.WriteLine(p);

                Console.WriteLine("\n--- Filter Products by Category (Electronics) ---");
                var electronics = products.Where(p => p.Category == "Electronics");
                foreach (var p in electronics)
                    Console.WriteLine(p);
            }
        }
    }
}
