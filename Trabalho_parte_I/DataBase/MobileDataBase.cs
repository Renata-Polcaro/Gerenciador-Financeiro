﻿using System; using System.Collections.Generic; using SQLite; using System.Linq; using Xamarin.Forms;


namespace Trabalho_parte_I { 	public class MobileDatabase 	{ 		static object locker = new object();  		protected SQLiteConnection database;   		public MobileDatabase() 		{ 			database = DependencyService.Get<ISQLite>().GetConnection(); 			CreateAllTables(); 		}  		public void CreateAllTables() 		{ 			database.CreateTable<Cadastro>(); 			database.CreateTable<Cadastro_dividas>(); 			database.CreateTable<Cadastro_lucros>(); 		}  		public SQLiteCommand CreateCommand(string cmdText, params object[] ps) 		{ 			lock (locker) 			{ 				return database.CreateCommand(cmdText, ps); 			} 		}  		public void Commit() 		{ 			lock (locker) 			{ 				database.Commit(); 			} 		}  		public IEnumerable<T> GetAll<T>() where T : class, new() 		{ 			lock (locker) 			{ 				return (from i in database.Table<T>() 						select i).ToList(); 			} 		}  		public IEnumerable<T> GetBySpcification<T>(Func<T, bool> predicate) where T : class, new() 		{ 			lock (locker) 			{ 				return database.Table<T>().Where(predicate); 			} 		}  		public T GetFirstBySpcification<T>(Func<T, bool> predicate) where T : class, new() 		{ 			lock (locker) 			{ 				return database.Table<T>().FirstOrDefault(predicate); 			} 		}  		public void Update<T>(T item) where T : class 		{ 			lock (locker) 			{ 				database.Update(item); 			} 		}  		public void Insert<T>(T item) where T : class 		{ 			lock (locker) 			{ 				database.Insert(item); 			} 		}  		public void Delete<T>(T item) where T : class, new() 		{ 			lock (locker) 			{ 				database.Delete<T>(item); 			} 		}  		public int Delete<T>(int id) where T : class, new() 		{ 			lock (locker) 			{ 				return database.Delete<T>(id); 			} 		}  		public int Execute(string query, params object[] args) 		{ 			return database.Execute(query, args); 		}  		public bool TableExists(string table) 		{ 			var command = database.CreateCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" + table + "'"); 			var result = command.ExecuteScalar<string>();  			if ((result != null) && (result.Trim().Length > 0)) 				return true; 			else 				return false; 		} 	} }