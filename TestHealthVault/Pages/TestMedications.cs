using Bunit;
using Microsoft.Extensions.DependencyInjection;
using HealthVault.Pages;

namespace TestHealthVault
{
	[Collection("HealthVault")]
	public class TestMedications
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Medications>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
