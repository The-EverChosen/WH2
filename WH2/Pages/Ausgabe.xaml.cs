namespace WH2;

public partial class Ausgabe : ContentPage
{
	public Ausgabe()
	{
		InitializeComponent();
	}
    private void GeheZuEingabe(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ausgabe());
    }
    private void GeheZuAusgabe(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Eingabe());
    }


}