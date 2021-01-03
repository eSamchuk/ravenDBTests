using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Documents;

namespace RavenDbClient.Model
{
    // The `DocumentStoreHolder` class holds a single Document Store instance.
    public class DocumentStoreHolder
    {
        // Use Lazy<IDocumentStore> to initialize the document store lazily. 
        // This ensures that it is created only once - when first accessing the public `Store` property.
        private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

        public static IDocumentStore Store => store.Value;

        private static IDocumentStore CreateStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                // Define the cluster node URLs (required)
                Urls = new[] { "https://ravenDb.test.com:8080" },

                // Set conventions as necessary (optional)
                Conventions =
                {
                    MaxNumberOfRequestsPerSession = 10,
                    UseOptimisticConcurrency = true
                },

                // Define a default database (optional)
                //Database = "TestDb",

                // Define a client certificate (optional)
                Certificate = new X509Certificate2(@"D:\IIG_Work\RavenDb\RavenDB-5.1.2-windows-x64\Server\Certificates\client.ravenDb.test.com.pfx", "Edrfo2021"),
            };

            return store;
        }
    }
}
