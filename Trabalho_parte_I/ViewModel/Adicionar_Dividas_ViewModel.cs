using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Adicionar_Dividas_ViewModel : BaseViewModel
	{
		private Cadastro_dividas cadastro;

		public Adicionar_Dividas_ViewModel()
		{
			Cadastro = new Cadastro_dividas();
		}

		public Cadastro_dividas Cadastro
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
			Repository<Cadastro_dividas> repositorio = new Repository<Cadastro_dividas>();
			if (Cadastro.Nome_divida == null)
			{
				await Dialogs.AlertAsync("Favor preencher o nome da dívida!", "Atenção", "Ok", null);
			}
			else if (Cadastro.Valor_divida == null)
			{
				await Dialogs.AlertAsync("Favor preencher o valor da dívida!", "Atenção", "Ok", null);
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


