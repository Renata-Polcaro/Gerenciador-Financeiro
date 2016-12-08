using System;
using SQLite;
using Xamarin.Forms;

namespace Trabalho_parte_I
{
	public class Cadastro
	{
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get;
			set;
		}

		public string Nome
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		public int Sexo
		{
			get;
			set;
		}

		public string Dt_Nasc
		{
			get;
			set;
		}

		public string Telefone
		{
			get;
			set;
		}

		public string Senha
		{
			get;
			set;
		}

		public string Numero
		{
			get;
			set;
		}

		public int Bandeira
		{
			get;
			set;
		}

		public DateTime Data_Expedicao
		{
			get;
			set;
		}

		public string Codigo
		{
			get;
			set;
		}
	}
}
