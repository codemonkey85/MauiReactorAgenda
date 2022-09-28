namespace MauiReactorAgenda.Pages;

public class MainPageViewModel : BaseViewModel
{
    public ObservableCollection<AgendaItem> AgendaItems { get; set; } = new()
    {
        new () { Title = "Item 1" },
        new () { Title = "Item 2" },
        new () { Title = "Item 3" },
    };

    public MainPageViewModel()
    {
        Title = "My Agenda";
    }
}
