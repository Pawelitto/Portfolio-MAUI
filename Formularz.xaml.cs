namespace Portfolio;

public partial class Formularz : ContentPage
{
	public Formularz()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var name = name_entry.Text;
        var phone = phone_entry.Text;

        if (string.IsNullOrWhiteSpace(name) || name.Length < 4)
        {
            DisplayAlert("B��d", "Prosz� poda� imi� i nazwisko.", "Rozumiem");
            return;
        }

        if (string.IsNullOrWhiteSpace(phone) || phone.Length < 9 || !phone.All(char.IsDigit))
        {
            DisplayAlert("B��d", "Numer telefonu musi mie� co najmniej 9 znak�w i zawiera� tylko cyfry.", "Rozumiem");
            return;
        }

        DisplayAlert("Sukces", "Pomy�lnie wys�ano dane", "Okej");
    }
}