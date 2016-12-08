using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Trabalho_parte_I_ViewModel : BaseViewModel
	{
		private Cadastro cadastro;

		public Trabalho_parte_I_ViewModel()
		{
			cadastro = new Cadastro();
		}

		public Cadastro Cadastro
		{
			get
			{
				return cadastro;
			}
			set
			{
				cadastro = value;

				if (value == null)
					return;


				OnPropertyChanged("Cadastro");
			}
		}

		Command login;
		public Command Login
		{
			get
			{
				return login ??
					(login = new Command(ExecutelLoginCommand));
			}
		}

		async void ExecutelLoginCommand()
		{

			Repository<Cadastro> repositorio = new Repository<Cadastro>();
			var usu = repositorio.GetFirstBySpcification<Cadastro>(c => c.Email == Cadastro.Email && c.Senha == Cadastro.Senha);

			if (usu == null)
			{
				await Dialogs.AlertAsync("Usuário não existe ou dados incorretos.", "Atenção", "Ok", null);
			}
			else
			{
				await this.PushAsync(new Escolher_opcoes_View());
			}

		}


		Command registrar;
		public Command Registrar
		{
			get
			{
				return registrar ??
					(registrar = new Command(ExecutelRegistrarCommand));
			}
		}

		async void ExecutelRegistrarCommand()
		{
			await this.PushAsync(new Cadastro_View());
		}

	}
}



