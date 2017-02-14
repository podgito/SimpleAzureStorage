using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Pojito.Azure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojito.Azure.Storage
{
    public class StorageFactory : IStorageFactory
    {
        private readonly string connectionString;

        public StorageFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ITableStorageClient<T> CreateTableStorageClient<T>(string tableName) where T : ITableEntity
        {
            //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            throw new NotImplementedException();
        }

    }
}
