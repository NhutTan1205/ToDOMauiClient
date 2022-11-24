using System.Diagnostics;
using ToDOMauiClient.DataServices;

namespace ToDOMauiClient;

public partial class MainPage : ContentPage
{   
    private readonly IRestDataService _dataService;
    private object collectionView;

    public MainPage(IRestDataService dataService)
    {
        InitializeComponent();

        _dataService = dataService;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
    }

    async void OnAddToDoClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("----> Add button clicked");
    }

    async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Debug.WriteLine("----> Item changed clicked");
    }

    private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}

