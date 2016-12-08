using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Relatorio_dividas_ViewModel : BaseViewModel
	{
		Repository<Cadastro> repositorio = new Repository<Cadastro>();


		public Relatorio_dividas_ViewModel()
		{
			Dados_Relatorio = repositorio.GetAll<Cadastro_dividas>().ToList();
		}

		List<Cadastro_dividas> dados_relatorio;
		public List<Cadastro_dividas> Dados_Relatorio 
		{ 
			get
			{
				return dados_relatorio;
			}

			set 
			{
				dados_relatorio = value;

				OnPropertyChanged("Dados_Relatorio");
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

