namespace Trabalho;

public partial class pgTema : ContentPage
{
	public pgTema()
	{
		InitializeComponent();
	}

    private void btnTema_Clicked(object sender, EventArgs e)
    {
        var temaAtual = App.Current.UserAppTheme;

        if (temaAtual == AppTheme.Dark)
        {
            App.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            App.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}