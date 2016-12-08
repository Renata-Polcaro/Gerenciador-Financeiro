using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Trabalho_parte_I_View : ContentPage
	{
		public Trabalho_parte_I_View()
		{
			InitializeComponent();
			BindingContext = new Trabalho_parte_I_ViewModel();
		}
	}
}
