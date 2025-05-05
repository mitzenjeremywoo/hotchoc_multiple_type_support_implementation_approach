namespace apollo_gateway.Types.CodeFirst
{
    public class BlogQueryType : ObjectType<CodeFirstDataRetriver>
    {

        protected override void Configure(IObjectTypeDescriptor<CodeFirstDataRetriver> descriptor)
        {
            descriptor
                .Field(f => f.GetBlog())
                .Type<BlogGraphqlSchema>();

            // you can further move this into a different method and configure descriptor
            // if you thinking of separating into different classes for separation of concerns
            descriptor
                .Field(f => f.GetComment())
                .Type<CommentGraphqlSchema>();
        }
    }

    public class CommentGraphqlSchema : ObjectType<Comment>
    {
        protected override void Configure(IObjectTypeDescriptor<Comment> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Type<StringType>();

            descriptor
                .Field(f => f.UserInput)
                .Type<StringType>();
        }
    }

    public class BlogGraphqlSchema : ObjectType<Blog>
    {
        protected override void Configure(IObjectTypeDescriptor<Blog> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Type<StringType>();

            descriptor
                .Field(f => f.UserInput)
                .Type<StringType>();
        }
    }

    public class Comment
    {
        public int Id { get; set; }

        public string UserInput { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }

        public string UserInput { get; set; }
    }

    public class CodeFirstDataRetriver
    {
        public Blog GetBlog()
        {
            return new Blog { Id = 1, UserInput = "test" };
        }

        public Comment GetComment()
        {
            return new Comment { Id = 1, UserInput = "test" };
        }
    }    
}
