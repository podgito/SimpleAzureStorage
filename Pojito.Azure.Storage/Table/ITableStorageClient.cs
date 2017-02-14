using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojito.Azure.Storage.Table
{
    public interface ITableStorageClient<T> where T : ITableEntity
    {

        void Insert(T item);

        void Insert(params T[] items);

        /// <summary>
        /// Gets all entities in a partition
        /// </summary>
        /// <param name="partitionKey"></param>
        /// <returns></returns>
        IEnumerable<T> Get(string partitionKey);

        /// <summary>
        /// Get an individual item
        /// </summary>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns></returns>
        T Get(string partitionKey, string rowKey);


    }
}
