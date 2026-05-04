using CashFlow.Application.UseCases.Users.Register;
using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Mapper;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using CommonTestUtilities.Token;
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
        var mapper = MapperBuilder.Build();

        var unitOfWork = UnitOfWorkBuilder.Build();

        var writeRepository = UserWriteOnlyRepositoryBuilder.Build();

        var passwordEncripter = PasswordEncripterBuilder.Build();

        var tokenGenerator = JwtTokenGeneratorBuilder.Build();

        return new RegisterUserUseCase(mapper, passwordEncripter, null, writeRepository, unitOfWork, tokenGenerator);
    }
}
