using System.Windows.Forms;

namespace FaizOraniHesaplama
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int gunfark;
		double faiz_oran1 =0.09;
		double faiz_oran2 =0.24;
		double sonuc = 0;
		double sonuc1 = 0;
		double sonuc2 = 0;

		double tazminat = 0;

		private void btnHesapla_Click(object sender, EventArgs e)
		{
			tazminat = Convert.ToDouble(textBox1.Text);
			DateTime karsilastirmaTarihi = new DateTime(2024, 6, 1);
			DateTime kazatarih = dtpKaza.Value;
			DateTime davatarih = dtpDava.Value;
			// Ýki tarih arasýndaki farký al
			TimeSpan fark = davatarih - kazatarih;

			// Elde edilen TimeSpan nesnesinin Days özelliði ile gün sayýsýný al
			int gunFarki = fark.Days;
			if (dtpKaza.Value>= karsilastirmaTarihi && dtpDava.Value >= karsilastirmaTarihi)
			{
				decimal a = ((decimal)gunFarki / 365);
				double guntaz = Convert.ToDouble( a)* faiz_oran2;
				sonuc =tazminat+ (tazminat * guntaz);
			}
			else if (dtpKaza.Value < karsilastirmaTarihi && dtpDava.Value >= karsilastirmaTarihi)
			{
				TimeSpan fark1 = karsilastirmaTarihi- kazatarih;
				int gunFarki1 = fark1.Days;
				TimeSpan fark2 = davatarih -karsilastirmaTarihi ;
				int gunFarki2 = fark2.Days;
				sonuc1 = (tazminat * (gunFarki1 / 365) * (faiz_oran1));
				sonuc2=(tazminat * (gunFarki2 / 365) * (faiz_oran2));
				sonuc = tazminat+sonuc1 + sonuc2;
			}
			lblSonuc.Text = sonuc.ToString();
		}

		private void dtpKaza_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
