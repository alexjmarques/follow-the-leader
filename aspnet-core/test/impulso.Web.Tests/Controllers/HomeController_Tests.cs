using System.Threading.Tasks;
using impulso.Models.TokenAuth;
using impulso.Web.Controllers;
using Shouldly;
using Xunit;

namespace impulso.Web.Tests.Controllers
{
    public class HomeController_Tests: impulsoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}