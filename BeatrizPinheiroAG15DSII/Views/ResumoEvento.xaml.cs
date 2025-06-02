using BeatrizPinheiroAG15DSII.Models;
using Microsoft.Maui.Controls;

namespace BeatrizPinheiroAG15DSII.Views;

public partial class ResumoEvento : ContentPage
{
	public ResumoEvento(Evento evento)
	{
		InitializeComponent();
		BindingContext = evento;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new TelaCadastro());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}