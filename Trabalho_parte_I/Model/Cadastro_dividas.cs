using System;
using SQLite;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Cadastro_dividas 
	{
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get;
			set;
		}

		public string Nome_divida
		{
			get;
			set;
		}

		public string Valor_divida
		{
			get;
			set;
		}

		public DateTime Data_divida
		{
			get;
			set;
		}

		public int Categoria_divida
		{
			get;
			set;
		}

		public string Divida_paga
		{
			get;
			set;
		}

		public bool switcher
		{
			get;
			set;
		}

	}
}

