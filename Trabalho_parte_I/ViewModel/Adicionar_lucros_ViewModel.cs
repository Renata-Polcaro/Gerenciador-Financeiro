using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Adicionar_lucros_ViewModel : BaseViewModel
	{
		private Cadastro_lucros cadastro;

		public Adicionar_lucros_ViewModel()
		{
			Cadastro = new Cadastro_lucros();
		}

		public Cadastro_lucros Cadastro
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
			Repository<Cadastro_lucros> repositorio = new Repository<Cadastro_lucros>();
			if (Cadastro.Nome_lucro == null)
			{
				await Dialogs.AlertAsync("Favor preencher o nome do lucro!", "Atenção", "Ok", null);
			}
			else if (Cadastro.Valor_lucro == null)
			{
				await Dialogs.AlertAsync("Favor preencher o valor do lucro!", "Atenção", "Ok", null);
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


