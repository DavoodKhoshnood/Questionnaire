using QuestionnaireApp.Domain.Common;

namespace QuestionnaireApp.Domain.Entities;

public class Subject : BaseEntity
{
    public string Name { get; private set; }

    public Guid CreatedByUserId { get; private set; }

    private Subject() { }

    public Subject(string name, Guid createdByUserId)
    {
        Name = name;
        CreatedByUserId = createdByUserId;
    }
}