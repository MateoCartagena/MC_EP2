namespace MC_EP2;

public partial class MainPage : ContentPage
{
	//private int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

  /*  
private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
	


    private void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = (RadioButton)sender;
        if (radioButton.IsChecked)
        {
            SelectedOptionLabel.Text = radioButton.Content.ToString();
        }
    }

    private async void OnRecargarButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Recarga Exitosa", "La recarga se realizó exitosamente.", "Aceptar");
    }
}


