using CommunityToolkit.Mvvm.Input;

namespace WH2;

public partial class Eingabe : ContentPage
{
	public Eingabe()
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

