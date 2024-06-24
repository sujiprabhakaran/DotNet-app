using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault.Pages;

namespace TestHealthVault
{
	[Collection("HealthVault")]
	public class TestEmergency
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Emergency>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
