using Azure.Data.Tables;
using Azure;

namespace Quiz.Entities;

public class GameEntity : ITableEntity
{
    public GameEntity() { }

    public GameEntity(string partitionKey, string rowKey)
    {
        PartitionKey = partitionKey;
        RowKey = rowKey;
    }

    public string PartitionKey { get; set; } = "1";
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.UtcNow;
    public ETag ETag { get; set; } = ETag.All;

    public DateTime? StartDate { get; set; }
    public int Status { get; set; }
    public int CurrentQuestion { get; set; }
    public bool AnswerIsRevealed { get; set; }
}