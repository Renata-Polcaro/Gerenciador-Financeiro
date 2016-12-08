using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Configuracoes_View : ContentPage
	{
		public Configuracoes_View()
		{
			InitializeComponent();
			BindingContext = new Configuracoes_ViewModel();
		}
	}
}
