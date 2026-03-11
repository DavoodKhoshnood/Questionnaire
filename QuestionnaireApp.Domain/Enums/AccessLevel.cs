namespace QuestionnaireApp.Domain.Enums;

public enum AccessLevel
{
    CreatorOnly = 1,
    AuthenticatedUsers = 2,
    PublicByLink = 3,
    PublicByQRCode = 4
}