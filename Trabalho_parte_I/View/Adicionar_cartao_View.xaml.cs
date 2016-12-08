using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Adicionar_cartao_View : ContentPage
	{
		public Adicionar_cartao_View()
		{
			InitializeComponent();
			BindingContext = new Adicionar_cartao_ViewModel();

			txtBandeira.Items.Add("Visa");
			txtBandeira.Items.Add("Master Card");
		}
	}
}
