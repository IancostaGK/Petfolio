using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets =
            [
                new() {
                    Id = 1,
                    Name = "Test",
                    Type = Communication.Enums.PetType.Dog 
                }
            ]
        };
    }
}
