using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestApp4.Pages;
using TestApp4.Financial;

namespace TestTestApp4
{
	public class TestIPhone11Pro
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule),
				typeof(IgbSliderModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<IPhone11Pro>();
			Assert.NotNull(componentUnderTest);
		}
	}
}