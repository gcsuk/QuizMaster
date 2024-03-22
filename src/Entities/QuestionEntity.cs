using Azure.Data.Tables;
using Azure;

namespace Quiz.Entities;

public class QuestionEntity : ITableEntity
{
    public QuestionEntity() { }

    public QuestionEntity(string rowKey)
    {
        RowKey = rowKey;
    }

    public string PartitionKey { get; set; } = "1";
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; } = DateTimeOffset.UtcNow;
    public ETag ETag { get; set; } = ETag.All;

    public int Number { get; set; }
    public string Question { get; set; }
    public string Answers { get; set; }
}