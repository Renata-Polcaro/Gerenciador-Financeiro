using System;

using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Relatorio_ViewModel : BaseViewModel
	{
		Command relatorio_lucros;
		public Command Relatorio_Lucros
		{
			get
			{
				return relatorio_lucros ??
					(relatorio_lucros = new Command(ExecuteLucrosCommand));
			}
		}

		async void ExecuteLucrosCommand()
		{
			await this.PushAsync(new Relatorio_lucros_View());
		}

		Command relatorio_dividas;
		public Command Relatorio_Dividas
		{
			get
			{
				return relatorio_dividas ??
					(relatorio_dividas = new Command(ExecuteDividasCommand));
			}
		}

		async void ExecuteDividasCommand()
		{
			await this.PushAsync(new Relatorio_dividas_View());
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

