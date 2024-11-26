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
            DisplayAlert("B³¹d", "Proszê podaæ imiê i nazwisko.", "Rozumiem");
            return;
        }

        if (string.IsNullOrWhiteSpace(phone) || phone.Length < 9 || !phone.All(char.IsDigit))
        {
            DisplayAlert("B³¹d", "Numer telefonu musi mieæ co najmniej 9 znaków i zawieraæ tylko cyfry.", "Rozumiem");
            return;
        }

        DisplayAlert("Sukces", "Pomyœlnie wys³ano dane", "Okej");
    }
}