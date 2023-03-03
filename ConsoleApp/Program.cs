using ServiceReference1;

MyServiceClient client = new MyServiceClient();
var result = await client.SumAsync(5, 10);

Console.WriteLine(result);
