using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public partial class Cadastro_View : ContentPage
	{
		public Cadastro_View()
		{
			InitializeComponent();
			BindingContext = new Cadastro_ViewModel();


			txtSexo.Items.Add("Masculino");
			txtSexo.Items.Add("Feminino");
		}
	}
}
