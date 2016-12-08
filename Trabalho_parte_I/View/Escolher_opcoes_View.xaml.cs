using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Escolher_opcoes_View : ContentPage
	{
		public Escolher_opcoes_View()
		{
			InitializeComponent();
			BindingContext = new Escolher_opcoes_ViewModel();
		}
	}
}
