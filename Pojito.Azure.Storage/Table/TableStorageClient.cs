using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojito.Azure.Storage.Table
{
    public class TableStorageClient<T> : ITableStorageClient<T> where T: ITableEntity
    {
        private readonly CloudStorageAccount storageAccount;
        private readonly CloudTableClient tableClient;

        internal TableStorageClient(CloudStorageAccount storageAccount, string tableName)
        {
            this.storageAccount = storageAccount;
            this.tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference(tableName);
            table.CreateIfNotExists();
        }



    }
}
