using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace CanneryCasino
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			Thread.Sleep(30000);
			app.Tap("title");
			Thread.Sleep(30000);
			app.Screenshot("Lets Tap on Cannery Casino");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(2));
			Thread.Sleep(30000);
			app.Screenshot("Then, We Tapped on 'Login Now'");
			Thread.Sleep(30000);
			app.Back();
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Back' Button");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(3));
			Thread.Sleep(30000);
			app.Screenshot("Then, We Tapped on 'My Cannery Account'");
			Thread.Sleep(30000);
			app.Back();
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Back' Button");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(4));
			Thread.Sleep(30000);
			app.Screenshot("Then we Tapped on 'My Canney Offers'");
			app.Back();
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Back' Button");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(5));
			Thread.Sleep(30000);
			app.Screenshot("Then we Tapped on 'More at Cannery'");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(1));
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on 'Promotions'");
			Thread.Sleep(30000);
			app.Back();
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Back' Button");

			Thread.Sleep(30000);
			app.Tap(x => x.Class("android.widget.TextView").Index(2));
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on 'Gaming'");
			Thread.Sleep(30000);
			app.Back();
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Back' Button");

			Thread.Sleep(30000);
			app.SwipeRightToLeft();
			Thread.Sleep(30000);
			app.Screenshot("Let's Swipe Right");

			Thread.Sleep(30000);
			app.SwipeRightToLeft();
			Thread.Sleep(30000);
			app.Screenshot("We Swiped Right again");
		}



	}
}
