namespace EventStore.Persistence.AzureTablePersistence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Logging;
    using Serialization;

    public class AzureTablePersistenceEngine : IPersistStreams
    {

        private static readonly ILog Logger = LogFactory.BuildLogger(typeof(AzureTablePersistenceEngine));
        private readonly IDocumentSerializer serializer;
        private bool disposed;
        private int initialized;

        public AzureTablePersistenceEngine(IDocumentSerializer serializer)
        {
            if (serializer == null)
                throw new ArgumentNullException("serializer");

            this.serializer = serializer;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposing || this.disposed)
                return;

            Logger.Debug("Shutting down persistence"); //Messages.ShuttingDownPersistence);
            this.disposed = true;
        }

        public virtual void Initialize()
        {
            if (Interlocked.Increment(ref this.initialized) > 1)
                return;

            Logger.Debug("Initializing Storage"); // Messages.InitializingStorage);
        }

        public virtual IEnumerable<Commit> GetFrom(System.DateTime start)
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerable<Commit> GetUndispatchedCommits()
        {
            throw new System.NotImplementedException();
        }

        public virtual void MarkCommitAsDispatched(Commit commit)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Purge()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Commit> GetFrom(System.Guid streamId, int minRevision, int maxRevision)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Commit(Commit attempt)
        {
            throw new System.NotImplementedException();
        }

        public virtual Snapshot GetSnapshot(System.Guid streamId, int maxRevision)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool AddSnapshot(Snapshot snapshot)
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerable<StreamHead> GetStreamsToSnapshot(int maxThreshold)
        {
            throw new System.NotImplementedException();
        }
    }
}
