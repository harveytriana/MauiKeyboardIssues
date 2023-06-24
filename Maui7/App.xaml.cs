namespace Maui7;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        ModifyEntry();

        MainPage = new AppShell();
	}

    // MAUI .NET 7
    // Issue: Entry Return command not firing up - .NET MAUI MVVM on Android #13921
    // FIX
    // https://github.com/dotnet/maui/issues/13921#issuecomment-1559057319
    // By: Henrik Sozzi
    static void ModifyEntry()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.KeyPress += (sender, e) =>
            {
                try
                {
                    if(e.KeyCode == Android.Views.Keycode.Tab || e.KeyCode == Android.Views.Keycode.Enter)
                    {
                        e.Handled = true;
                        if((e.KeyCode == Android.Views.Keycode.Enter) && (e.Event.Action == Android.Views.KeyEventActions.Up))
                        {
                            //((Entry)handler.VirtualView).ReturnCommand?.Execute(((Entry)handler.VirtualView).ReturnCommandParameter);
                            ((Entry)handler.VirtualView).SendCompleted();
                        }
                    }
                    else
                        e.Handled = false;
                }
                catch(Exception)
                {
                    System.Diagnostics.Debug.WriteLine("ModifyEntry error...");
                }
            };
#endif
        });
    }
}
