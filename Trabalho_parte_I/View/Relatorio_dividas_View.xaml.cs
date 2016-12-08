using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Relatorio_dividas_View : ContentPage
	{
		public Relatorio_dividas_View()
		{
			InitializeComponent();
			BindingContext = new Relatorio_dividas_ViewModel();
		}
	}
}
