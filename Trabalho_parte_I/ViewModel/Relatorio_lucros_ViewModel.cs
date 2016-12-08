using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Relatorio_lucros_ViewModel : BaseViewModel
	{
		Repository<Cadastro> repositorio = new Repository<Cadastro>();

		public Relatorio_lucros_ViewModel()
		{
			Dados_Relatorio = repositorio.GetAll<Cadastro_lucros>().ToList();
		}

		List<Cadastro_lucros> dados_relatorio;
		public List<Cadastro_lucros> Dados_Relatorio
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

