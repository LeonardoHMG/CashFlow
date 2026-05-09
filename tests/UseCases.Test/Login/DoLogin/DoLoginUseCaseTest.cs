using CashFlow.Application.UseCases.Login.DoLogin;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;
using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Entities;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using CommonTestUtilities.Token;
using Shouldly;

namespace UseCases.Test.Login.DoLogin;
public class DoLoginUseCaseTest
{
    [Fact]
    public async Task Success()
    {
        var user = UserBuilder.Build();

        var request = RequestLoginJsonBuilder.Build();

        var useCase = CreateUseCase(user);

        var result = await useCase.Execute(request);

        result.ShouldNotBeNull();
        result.Name.ShouldBe(user.Name);
        result.Token.ShouldNotBeNullOrWhiteSpace();
    }

    [Fact]
    public async Task Error_User_Not_Found()
    {
        var user = UserBuilder.Build();

        var request = RequestLoginJsonBuilder.Build();

        var useCase = CreateUseCase(user);

        var exception = await Should.ThrowAsync<InvalidLoginException>(() =>
            useCase.Execute(request)
        );

        exception.GetErrors().ShouldHaveSingleItem().ShouldBe(ResourceErrorMessages.EMAIL_OR_PASSWORD_INVALID);
    }

    [Fact]
    public async Task Error_Password_Not_Match()
    {
        var user = UserBuilder.Build();

        var request = RequestLoginJsonBuilder.Build();

        var useCase = CreateUseCase(user);

        var exception = await Should.ThrowAsync<InvalidLoginException>(() =>
            useCase.Execute(request)
        );

        exception.GetErrors().ShouldHaveSingleItem().ShouldBe(ResourceErrorMessages.EMAIL_OR_PASSWORD_INVALID);
    }

    private DoLoginUseCase CreateUseCase(CashFlow.Domain.Entities.User user)
    {
        var passwordEncripter = PasswordEncripterBuilder.Build();
        var tokenGenerator = JwtTokenGeneratorBuilder.Build();
        var readRepository = new UserReadOnlyRepositoryBuilder().GetUserByEmail(user).Build();

        return new DoLoginUseCase(readRepository, passwordEncripter, tokenGenerator);
    }
}
