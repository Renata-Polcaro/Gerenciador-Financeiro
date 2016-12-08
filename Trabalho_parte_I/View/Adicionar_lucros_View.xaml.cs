using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Adicionar_lucros_View : ContentPage
	{
		public Adicionar_lucros_View()
		{
			InitializeComponent();
			BindingContext = new Adicionar_lucros_ViewModel();
		}
	}
}
