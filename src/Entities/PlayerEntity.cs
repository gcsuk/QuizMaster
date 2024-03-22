using Azure.Data.Tables;
using Azure;

namespace Quiz.Entities;

public class PlayerEntity : ITableEntity
{
    public PlayerEntity() { }

    public PlayerEntity(string partitionKey, string rowKey)
    {
        PartitionKey = partitionKey;
        RowKey = rowKey;
    }

    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.UtcNow;
    public ETag ETag { get; set; } = ETag.All;

    public string Name { get; set; }
    public int Pin { get; set; }
}