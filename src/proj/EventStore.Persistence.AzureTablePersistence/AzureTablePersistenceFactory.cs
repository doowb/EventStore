namespace EventStore.Persistence.AzureTablePersistence
{
    using System.Configuration;
    using Serialization;

    public class AzureTablePersistenceFactory : IPersistenceFactory
    {
        private readonly string connectionName;
        private readonly IDocumentSerializer serializer;

        public AzureTablePersistenceFactory(string connectionName, IDocumentSerializer serializer)
        {
            this.connectionName = connectionName;
            this.serializer = serializer;
        }

        public virtual IPersistStreams Build()
        {
            // load azure table storage connections
            throw new System.NotImplementedException();
        }

    }
}
