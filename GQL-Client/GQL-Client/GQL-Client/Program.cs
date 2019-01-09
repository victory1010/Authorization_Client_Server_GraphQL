using System;
using System.Threading;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Common.Request;
using RestSharp;

namespace GQL_Client
{
    class Program
    {
        static void Main(string[] args)
        {
		       /* var graphClient = new GraphQLClient("http://localhost:60756/graphql");
		        graphClient.DefaultRequestHeaders.Add("Authorization",
			        $"bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyaWQiOiIxIiwidW5pcXVlX25hbWUiOiJwZXNobyIsImVtYWlsIjoicGVzaG9AdGVzdC5jb20iLCJmaXJzdG5hbWUiOiJQZXNobyIsImxhc3RuYW1lIjoiRGltaXRyb3YiLCJyb2xlIjpbIk1hbmFnZXIiLCJVc2VyIl0sIm5iZiI6MTUzOTUxMzU1NiwiZXhwIjoxNTM5NTE1MzU2LCJpYXQiOjE1Mzk1MTM1NTYsImlzcyI6IlNtYXJ0U3RvcmVzIiwiYXVkIjoiQ3VzdG9tQ2xpZW50In0.0GhVtgi3_m46hBILH-nGPMv4slGKaelhntNYDxbUBLc");
		        var request = new GraphQLRequest
		        {
			        Query = @"query { viewer { login } }"
		        };
		        var test = graphClient.PostAsync(request).Result;*/
	        
	        using (var graphQLHttpClient = new GraphQLHttpClient("http://localhost:60756/graphql")) {
		        graphQLHttpClient.DefaultRequestHeaders.Add("Authorization",
			        @"bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyaWQiOiIzIiwidW5pcXVlX25hbWUiOiJ2aWN0b3J5IiwiZW1haWwiOiJ2aWN0b3JpYXJhZGV2YUB5YWhvby5jby5ueiIsImZpcnN0bmFtZSI6IlZpY3RvcmlhIiwibGFzdG5hbWUiOiJSYWRldmEiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE1Mzk1MTU1MzYsImV4cCI6MTUzOTUxNzMzNiwiaWF0IjoxNTM5NTE1NTM2LCJpc3MiOiJTbWFydFN0b3JlcyIsImF1ZCI6IkN1c3RvbUNsaWVudCJ9.9XxG8i0WLGhRoWA97NDl98V4J3a9nCOIaH8CYoqN1OY");

		        var result = graphQLHttpClient.SendQueryAsync(@"
					{
						orders {
							id
						}
					}
				").Result;
		        Console.WriteLine(result.Data);
				Console.ReadKey();
			}
        }
    }
}
