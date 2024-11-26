
namespace Portfolio;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Projekty());
    }

    async private void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Omnie());
    }

    async private void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Formularz());
    }
}