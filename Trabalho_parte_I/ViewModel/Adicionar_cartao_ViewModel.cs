using System;

using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Adicionar_cartao_ViewModel : BaseViewModel
	{
		private Cadastro cadastro;

		public Adicionar_cartao_ViewModel()
		{
			Cadastro = new Cadastro();
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

		Command salvar;
		public Command Salvar
		{
			get
			{
				return salvar ??
					(salvar = new Command(ExecuteSalvarCommand));
			}
		}

		async void ExecuteSalvarCommand()
		{
			Repository<Cadastro> repositorio = new Repository<Cadastro>();
			if (Cadastro.Numero == null)
			{
				await Dialogs.AlertAsync("Favor preencher o número do cartão!", "Atenção", "Ok", null);
			}
			else if (Cadastro.Codigo == null)
			{
				await Dialogs.AlertAsync("Favor preencher o código do cartão!", "Atenção", "Ok", null);
			}
			else
				try
				{
					repositorio.Insert(Cadastro);
					await PopAsync();
				}
				catch
				{
					await Dialogs.AlertAsync("Aconteceu um erro ao salvar os dados!", "Atenção", "Ok", null);
				}
		}

		Command voltar;
		public Command Voltar
		{
			get
			{
				return voltar ??
					(voltar = new Command(ExecuteVoltarCommand));
			}
		}

		async void ExecuteVoltarCommand()
		{
			await this.PopAsync();
		}

	}
}




