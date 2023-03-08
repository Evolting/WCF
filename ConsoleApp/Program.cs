using ServiceReference1;
using ServiceReference2;

MyServiceClient client1 = new MyServiceClient();
var result = await client1.SumAsync(5, 10);

Console.WriteLine(result);

ProductServiceClient client2 = new ProductServiceClient();
Task<Product[]> products = client2.GetProductsAsync(1);
products.Result.ToList().ForEach(p => Console.WriteLine(p.ProductID+" "+p.ProductName));