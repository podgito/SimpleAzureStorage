using Microsoft.WindowsAzure.Storage.Table;
using Pojito.Azure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojito.Azure.Storage
{
    public interface IStorageFactory
    {

        ITableStorageClient<T> CreateTableStorageClient<T>(string tableName) where T: ITableEntity;

    }
}
