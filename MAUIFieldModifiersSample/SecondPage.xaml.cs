namespace MAUIFieldModifiersSample;

public partial class SecondPage : ContentPage
{
    int count = 0;
    public SecondPage()
    {
        InitializeComponent();

        // Accessing CommonToolbarView Elements
        CommonToolbar.LblToolbarTitle.Text = "Second Page";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}