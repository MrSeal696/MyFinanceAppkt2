namespace MyFinanceApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnAddClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddTransactionPage));
    }

    private async void OnReportsClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReportsPage));
    }
}