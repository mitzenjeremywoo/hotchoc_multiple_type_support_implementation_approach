namespace apollo_gateway.Types;

//[QueryType]
public class BookDataFakeHelper
{
    public Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));
}

public class BookCodeFirstApproachQueryType : ObjectType<BookDataFakeHelper>
{
    protected override void Configure(IObjectTypeDescriptor<BookDataFakeHelper> descriptor)
    {
        descriptor
            .Field(f => f.GetBook())
            .Type<BookType>();
    }
}
public class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor
            .Field(f => f.Title)
            .Type<StringType>();

        descriptor
            .Field(f => f.Author)
            .Type<StringType>();
    }
}

