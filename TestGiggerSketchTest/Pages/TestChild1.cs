using Bunit;
using Microsoft.Extensions.DependencyInjection;
using GiggerSketchTest.Pages;

namespace TestGiggerSketchTest
{
	public class TestChild1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbExpansionPanelModule));
			var componentUnderTest = ctx.RenderComponent<Child1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}