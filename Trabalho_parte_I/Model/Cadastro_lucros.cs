using System;
using SQLite;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Cadastro_lucros 
	{
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get;
			set;
		}

		public string Nome_lucro
		{
			get;
			set;
		}

		public string Valor_lucro
		{
			get;
			set;
		}

		public DateTime Data_lucro
		{
			get;
			set;
		}
	}
}

