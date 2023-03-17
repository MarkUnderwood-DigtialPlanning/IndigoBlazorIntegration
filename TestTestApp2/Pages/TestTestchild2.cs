using Bunit;
using Microsoft.Extensions.DependencyInjection;
using GiggerSketchTest.Pages;

namespace TestGiggerSketchTest
{
	public class TestTestchild2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Testchild2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}