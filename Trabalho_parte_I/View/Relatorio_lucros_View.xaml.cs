using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Relatorio_lucros_View : ContentPage
	{
		public Relatorio_lucros_View()
		{
			InitializeComponent();
			BindingContext = new Relatorio_lucros_ViewModel();
		}
	}
}
