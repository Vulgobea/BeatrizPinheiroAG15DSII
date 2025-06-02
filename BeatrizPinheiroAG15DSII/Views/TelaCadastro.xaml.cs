using BeatrizPinheiroAG15DSII.Models;

namespace BeatrizPinheiroAG15DSII.Views;

public partial class TelaCadastro : ContentPage
{
    private Evento _evento = new Evento();

    public TelaCadastro()
    {
        InitializeComponent();

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day );

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
    }

    private async void CadastrarEvento(object sender, EventArgs e)
    {
        // Preenchendo a model com os dados da tela
        _evento.Nome = txtNome.Text;
        _evento.DataCheckIn = dtpck_checkin.Date;
        _evento.DataCheckOut = dtpck_checkout.Date;

        // Validando número de participantes
        int numeroParticipantes;
        if (int.TryParse(txtNumeroParticipantes.Text, out numeroParticipantes))
        {
            _evento.NumeroParticipantes = numeroParticipantes;
        }
        else
        {
            _evento.NumeroParticipantes = 0; // Valor padrão caso a entrada seja inválida
        }

        _evento.Local = txtLocal.Text;

        // Validando custo por participante
        decimal custoPorParticipante;
        if (decimal.TryParse(txtCustoPorParticipante.Text, out custoPorParticipante))
        {
            _evento.CustoPorParticipante = custoPorParticipante;
        }
        else
        {
            _evento.CustoPorParticipante = 0; // Valor padrão caso a entrada seja inválida
        }

        // Navegando para a tela de resumo com os dados do evento
        await Navigation.PushAsync(new ResumoEvento(_evento));
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

    }
}