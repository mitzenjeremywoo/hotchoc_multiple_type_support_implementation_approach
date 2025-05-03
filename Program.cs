using apollo_gateway.Types;

var builder = WebApplication.CreateBuilder(args);

// code first approach - letting you customize graphql
//builder.Services.AddGraphQLServer().AddApolloFederation().AddQueryType<BookCodeFirstApproachQueryType>();

// implementation approach
builder.Services.AddGraphQLServer().AddApolloFederation().AddQueryType(q => q.Name("Query"))
    .AddType<BookDataReturnDataHelper>().AddType<ProductDataReturnDataHelper>();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
