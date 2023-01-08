namespace MAUIFieldModifiersSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Accessing CommonToolbarView Elements
        CommonToolbar.LblToolbarTitle.Text = "Main Page";
        CommonToolbar.ImgToolbarBack.IsVisible = false;
    }

    private async void NavigateToSecondPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }
}

public partial class MainPage2 : MainPage
{
    public MainPage2()
    {
        // Accessing MainPage Image
        ImgDotNet.HeightRequest = 100;
        ImgDotNet.WidthRequest = 100;
    }
}
