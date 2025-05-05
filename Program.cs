using apollo_gateway.Types;
using apollo_gateway.Types.CodeFirst;

var builder = WebApplication.CreateBuilder(args);

//code first approach - letting you customize graphql
builder.Services.AddGraphQLServer().AddApolloFederation().AddQueryType<BlogQueryType>();

// implementation approach
//builder.Services.AddGraphQLServer().AddApolloFederation().AddQueryType(q => q.Name("Query"))
//    .AddType<BookDataReturnDataHelper>().AddType<ProductDataReturnDataHelper>();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
