using ObjCRuntime;

namespace MauiAppC_basic;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new MainPage();
	}

}
