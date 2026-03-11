using QuestionnaireApp.Domain.Common;
using QuestionnaireApp.Domain.Enums;

namespace QuestionnaireApp.Domain.Entities;

public class Questionnaire : BaseEntity
{
    public string Title { get; private set; }

    public string Description { get; private set; }

    public Guid CreatorId { get; private set; }

    public PrivacyType PrivacyType { get; private set; }

    public AccessLevel AccessLevel { get; private set; }

    public string? PublicAccessToken { get; private set; }

    private readonly List<Question> _questions = new();

    public IReadOnlyCollection<Question> Questions => _questions;

    private Questionnaire() { }

    public Questionnaire(
        string title,
        string description,
        Guid creatorId,
        PrivacyType privacyType,
        AccessLevel accessLevel)
    {
        Title = title;
        Description = description;
        CreatorId = creatorId;
        PrivacyType = privacyType;
        AccessLevel = accessLevel;

        if (accessLevel == AccessLevel.PublicByLink ||
            accessLevel == AccessLevel.PublicByQRCode)
        {
            PublicAccessToken = Guid.NewGuid().ToString();
        }
    }

    public void AddQuestion(Question question)
    {
        _questions.Add(question);
    }
}