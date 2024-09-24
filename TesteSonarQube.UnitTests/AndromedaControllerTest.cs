using Microsoft.AspNetCore.Mvc;
using TesteSonarQube.Controllers;

namespace TesteSonarQube.UnitTests
{
    public class AndromedaControllerTest
    {
        private readonly AndromedaController _andromedaController;

        public AndromedaControllerTest()
        {
            _andromedaController = new AndromedaController();
        }

        [Fact]
        public void Genesis_Should_ReturnsExpectedString()
        {
            // Act
            OkObjectResult okObjectResult = _andromedaController.Genesis() as OkObjectResult;

            // Assert
            Assert.NotNull(okObjectResult);
            Assert.Equal(200, okObjectResult.StatusCode);
            Assert.Equal("teste", okObjectResult.Value);
        }
    }
}