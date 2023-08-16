namespace App_Dinosaurio;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void BtnDatos_Clicked(object sender, EventArgs e)
	{
		string Dino1;
		int Kgs;
		int Mts;
		double Lbs;
		int Cms;

		Dino1 = Dino.Text;
		Kgs = Convert.ToInt32(Peso.Text);
		Mts = Convert.ToInt32(Altura.Text);

		Lbs = Kgs * 2.2;
		Cms = Mts * 100;

		LblDatos.Text = Dino1;
		LblPeso.Text = Lbs.ToString() + "" + "Libras";
		LblAltura.Text = Cms.ToString() + "" + "Centimetros";
    }
}

