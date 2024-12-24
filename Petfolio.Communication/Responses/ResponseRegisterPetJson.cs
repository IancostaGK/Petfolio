using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponseRegisterPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
