using QuestionnaireApp.Domain.Common;

namespace QuestionnaireApp.Domain.Entities;

public class Answer : BaseEntity
{
    public Guid SubjectId { get; private set; }

    public Guid QuestionId { get; private set; }

    public string? TextAnswer { get; private set; }

    public double? NumberAnswer { get; private set; }

    public Guid? SelectedOptionId { get; private set; }

    private Answer() { }

    public Answer(Guid subjectId, Guid questionId)
    {
        SubjectId = subjectId;
        QuestionId = questionId;
    }

    public void SetTextAnswer(string value)
    {
        TextAnswer = value;
    }

    public void SetNumberAnswer(double value)
    {
        NumberAnswer = value;
    }

    public void SelectOption(Guid optionId)
    {
        SelectedOptionId = optionId;
    }
}