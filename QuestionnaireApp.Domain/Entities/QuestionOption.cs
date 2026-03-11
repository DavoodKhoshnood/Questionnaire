using QuestionnaireApp.Domain.Common;

namespace QuestionnaireApp.Domain.Entities;

public class QuestionOption : BaseEntity
{
    public Guid QuestionId { get; private set; }

    public string Value { get; private set; }

    private QuestionOption() { }

    public QuestionOption(Guid questionId, string value)
    {
        QuestionId = questionId;
        Value = value;
    }
}