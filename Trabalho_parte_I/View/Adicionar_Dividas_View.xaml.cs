using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Adicionar_Dividas_View : ContentPage
	{
		public Adicionar_Dividas_View()
		{
			InitializeComponent();
			BindingContext = new Adicionar_Dividas_ViewModel();

			txtCategoria_divida.Items.Add("Supermercado/Mercado"); 			txtCategoria_divida.Items.Add("Calçados"); 			txtCategoria_divida.Items.Add("Roupas"); 			txtCategoria_divida.Items.Add("Eletro/Eletrônicos"); 			txtCategoria_divida.Items.Add("Presente"); 			txtCategoria_divida.Items.Add("Lazer"); 			txtCategoria_divida.Items.Add("Outros");
		}
	}
}
