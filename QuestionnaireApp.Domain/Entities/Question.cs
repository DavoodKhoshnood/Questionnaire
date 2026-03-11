using QuestionnaireApp.Domain.Common;
using QuestionnaireApp.Domain.Enums;

namespace QuestionnaireApp.Domain.Entities;

public class Question : BaseEntity
{
    public Guid QuestionnaireId { get; private set; }

    public string Text { get; private set; }

    public QuestionType QuestionType { get; private set; }

    private readonly List<QuestionOption> _options = new();

    public IReadOnlyCollection<QuestionOption> Options => _options;

    private Question() { }

    public Question(Guid questionnaireId, string text, QuestionType type)
    {
        QuestionnaireId = questionnaireId;
        Text = text;
        QuestionType = type;
    }

    public void AddOption(QuestionOption option)
    {
        if (QuestionType == QuestionType.Text || QuestionType == QuestionType.Number)
            throw new InvalidOperationException("Options not allowed for this question type");

        _options.Add(option);
    }
}