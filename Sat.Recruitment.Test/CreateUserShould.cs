using Microsoft.AspNetCore.Mvc;
using Moq;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Service;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class CreateUserShould
    {
        [Fact]
        public void ReturnOK()
        {
            //Arrange
            var user = Mocks.Mocks.MockUser();
            var userService = new Mock<IUserService>();
            userService.Setup(x => x.CreateUser(user)).Returns(Mocks.Mocks.MockSuccessResponse);
            var sut = new UserController(userService.Object);

            // arrange
            var result = (OkObjectResult)sut.CreateUser(user);

            // Assert
            Assert.True(result.StatusCode == 200);
        }
    }
}
