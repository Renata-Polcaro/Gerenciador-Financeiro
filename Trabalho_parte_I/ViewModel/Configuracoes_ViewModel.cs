using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Configuracoes_ViewModel : BaseViewModel
	{
		private Configuracoes configuracoes;

		public Configuracoes_ViewModel()
		{
			configuracoes = new Configuracoes();
		}

		public Configuracoes Configuracoes
		{
			get
			{
				return configuracoes;
			}
			set
			{
				configuracoes = value;

				if (value == null)
					return;


				OnPropertyChanged("Configuracoes");
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
			await this.PopAsync();
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


