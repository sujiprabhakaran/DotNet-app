using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault.Pages;

namespace TestHealthVault
{
	[Collection("HealthVault")]
	public class TestProfile
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Profile>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
