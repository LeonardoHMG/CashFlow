using CashFlow.Application.UseCases.Users.Register;
using CommonTestUtilities.Requests;
using Shouldly;

namespace UseCases.Test.Users.Register;
public class RegisterUserUseCaseTest
{
    [Fact]
    public async Task Success()
    {
        var resquest = RequestRegisterUserJsonBuilder.Build();
        var useCase = CreateUseCase();

        var result = await useCase.Execute(resquest);

        result.ShouldNotBeNull();
        result.Name.ShouldBe(resquest.Name);
        result.Token.ShouldNotBeNullOrWhiteSpace();
    }

    private RegisterUserUseCase CreateUseCase()
    {
        return new RegisterUserUseCase(null, null, null, null, null, null);
    }
}
