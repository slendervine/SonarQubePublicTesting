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
            var result = _andromedaController.Genesis();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("teste", result.Value);
        }

        [Fact]
        public void Andromeda_Should_ReturnsExpectedString()
        {
            // Act
            var result = _andromedaController.Andromeda() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("lançar correntes!!!!", result.Value);
        }
    }
}