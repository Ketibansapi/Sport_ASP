using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using System.Configuration;
using System.Linq.Expressions;
using System.Net;
//using Microsoft.Extensions.Configuration;
using System.IO;
/*
namespace SportTransfer4
{
    public class DocumentDBRespository<T> where T : class
    {
        private static readonly string DatabaseId = "ToDoList";
        private static readonly string CollectionId = "Items";
        private static DocumentClient client;
        public static void Initialize()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            IConfigurationRoot Configuration = builder.Build();
            client = new DocumentClient(new
           Uri(Configuration["Setting1:url"]),
           Configuration["Setting1:key"]);
            CreateDatabaseIfNotExistsAsync().Wait();
            CreateCollectionIfNotExistsAsync().Wait();
        }
        private static async Task CreateDatabaseIfNotExistsAsync()
        {
            try
            {
                await
               client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId))
               ;
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode ==
               System.Net.HttpStatusCode.NotFound)
                {
                    await client.CreateDatabaseAsync(new Database
                    { Id = DatabaseId });
                }
                else
                {
                    throw;
                }
            }
        }
        private static async Task
       CreateCollectionIfNotExistsAsync()
        {
            try
            {
                await
client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId));
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode ==
               System.Net.HttpStatusCode.NotFound)
                {
                    await client.CreateDocumentCollectionAsync(
                    UriFactory.CreateDatabaseUri(DatabaseId),
                    new DocumentCollection
                    {
                        Id = CollectionId
                    },
                    new RequestOptions
                    {
                        OfferThroughput =
                   1000
                    });
                }
                else
                {
                    throw;
                }
            }
        }
    }
    */