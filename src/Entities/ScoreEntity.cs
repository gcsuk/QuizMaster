using Azure.Data.Tables;
using Azure;

namespace Quiz.Entities;

public class ScoreEntity : ITableEntity
{
    public ScoreEntity() { }

    public ScoreEntity(string partitionKey, string rowKey)
    {
        PartitionKey = partitionKey;
        RowKey = rowKey;
    }

    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.UtcNow;
    public ETag ETag { get; set; } = ETag.All;

    public int Score { get; set; }
}