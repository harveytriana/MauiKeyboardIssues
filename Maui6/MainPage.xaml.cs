using System.Collections.ObjectModel;

namespace Maui6;

public partial class MainPage : ContentPage
{
    readonly ObservableCollection<string> _messages = new();

    int _counter = 0;

    public MainPage()
    {
        InitializeComponent();

        buttonConnect.Clicked += async (s, e) => await ConnectAsync();
        entryMessage.Completed += async (s, e) => await SendMessageAsync();
        //
        listViewMessages.ItemsSource = _messages;
    }

    // simulate
    async Task ConnectAsync()
    {
        buttonConnect.IsEnabled = false;
        // do connection.. The deatils is not the point of this sample

        await Task.Delay(1000);

        // change ui to real time messages
        stackLayoutLogIn.IsVisible = false;
        gridMessages.IsVisible = true;

        labelTitle.Text = "Messages Board MAUI .NET 6";
    }

    async Task SendMessageAsync()
    {
        // simulates sending messages
        await Task.Delay(200);
        // await _connection.SendAsync("SendMessage", UserName, Message);
        AppendMessage($"{DateTime.Now:HH:mm:ss}: {++_counter} {Message}");

        Message = string.Empty;
    }

    private void AppendMessage(string message)
    {
        _messages.Add(message);
        listViewMessages.ScrollTo(_messages.Last(), ScrollToPosition.End);
    }

    string Message
    {
        get => entryMessage.Text;
        set => entryMessage.Text = value;
    }
}