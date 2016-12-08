/*using System;

using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class App1 : Application
	{
		public App1()
		{

			StackLayout layout = new StackLayout();
			layout.VerticalOptions = LayoutOptions.Center;


			Label label = new Label
			{
				Text = "Cadastro de Usuário\n",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand

			};

			Entry nome = new Entry
			{
				HorizontalTextAlignment = TextAlignment.Start,
				Placeholder = "Nome",
				Keyboard = Keyboard.Text
			};

			Picker sexo = new Picker
			{
				Title = "Sexo",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};


			DatePicker data = new DatePicker
			{
				Format = "D",
				VerticalOptions = LayoutOptions.Center

			};

			Entry email = new Entry
			{
				HorizontalTextAlignment = TextAlignment.Start,
				Keyboard = Keyboard.Email,
				Placeholder = "Email"
			};

			Entry senha = new Entry
			{
				HorizontalTextAlignment = TextAlignment.Start,
				Placeholder = "Senha",
				Keyboard = Keyboard.Text,
				IsPassword = true
			};

			Label ativo = new Label
			{
				Text = "Usuário Ativo",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand

			};

			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Button cadastrar = new Button
			{
				Text = "    Cadastrar    ",
				BorderWidth = 0.5,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Button voltar = new Button
			{
				Text = "       Voltar       ",
				BorderWidth = 0.5,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			layout.Children.Add(label);
			sexo.Items.Add("Male");
			sexo.Items.Add("Female");
			layout.Children.Add(nome);
			layout.Children.Add(sexo);
			layout.Children.Add(data);
			layout.Children.Add(email);
			layout.Children.Add(senha);
			layout.Children.Add(ativo);
			layout.Children.Add(switcher);
			layout.Children.Add(cadastrar);
			layout.Children.Add(voltar);




			var content = new ContentPage
			{
				Title = "Trabalho_parte_I",
				Content = layout
			};

			MainPage = content;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
*/