namespace apollo_gateway.Types;

[ExtendObjectType("Query")]

public class BookDataReturnDataHelper
{
    public Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));
}

[ExtendObjectType("Query")]
public class ProductDataReturnDataHelper
{
    public Product GetProduct()
        => new Product("C# in depth.", new Author("Jon Skeet"));
}