using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestApp2.Pages;
using TestApp2.Financial;

namespace TestTestApp2
{
	public class TestIPhone11Pro
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<IPhone11Pro>();
			Assert.NotNull(componentUnderTest);
		}
	}
}