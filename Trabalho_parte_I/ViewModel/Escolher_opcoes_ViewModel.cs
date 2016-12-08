using System;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Escolher_opcoes_ViewModel : BaseViewModel
	{
			Command lucros;
			public Command Lucros
			{
				get
				{
				return lucros ??
					(lucros = new Command(ExecuteLucrosCommand));
				}
			}

			async void ExecuteLucrosCommand()
			{
				await this.PushAsync(new Adicionar_lucros_View());
			}

		Command dividas;
		public Command Dividas
		{
			get
			{
				return dividas ??
					(dividas = new Command(ExecuteDividasCommand));
			}
		}

		async void ExecuteDividasCommand()
		{
			await this.PushAsync(new Adicionar_Dividas_View());
		}

		Command cartao;
		public Command Cartao
		{
			get
			{
				return cartao ??
					(cartao = new Command(ExecuteCartaoCommand));
			}
		}

		async void ExecuteCartaoCommand()
		{
			await this.PushAsync(new Adicionar_cartao_View());
		}


		Command relatorios;
		public Command Relatorios
		{
			get
			{
				return relatorios ??
					(relatorios = new Command(ExecuteRelatoriosCommand));
			}
		}

		async void ExecuteRelatoriosCommand()
		{
			await this.PushAsync(new Relatorio_View());
		}

		Command configuracoes;
		public Command Configuracoes
		{
			get
			{
				return configuracoes ??
					(configuracoes = new Command(ExecuteConfiguracoesCommand));
			}
		}

		async void ExecuteConfiguracoesCommand()
		{
			await this.PushAsync(new Configuracoes_View());
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


