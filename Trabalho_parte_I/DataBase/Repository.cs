﻿using System; //using Xamarin.Forms; using System.Linq; using System.Collections.Generic;  namespace Trabalho_parte_I { 	public class Repository<TEntity> 	{ 		public MobileDatabase MobileDatabase { get; private set; }  		public Repository() 		{ 			MobileDatabase = new MobileDatabase(); 		}  		public IEnumerable<T> GetAll<T>() where T : class, new() 		{ 			return MobileDatabase.GetAll<T>(); 		}  		public IEnumerable<T> GetBySpcification<T>(Func<T, bool> predicate) where T : class, new() 		{ 			return MobileDatabase.GetBySpcification<T>(predicate); 		}  		public T GetFirstBySpcification<T>(Func<T, bool> predicate) where T : class, new() 		{ 			return MobileDatabase.GetFirstBySpcification<T>(predicate); 		}  		public void Update<T>(T item) where T : class 		{ 			MobileDatabase.Update<T>(item); 		}  		public void Insert<T>(T item) where T : class 		{ 			MobileDatabase.Insert<T>(item); 		}  		public void Delete<T>(T item) where T : class, new() 		{ 			MobileDatabase.Delete<T>(item); 		}  		public void Delete<T>(int id) where T : class, new() 		{ 			MobileDatabase.Delete<T>(id); 		}  		public void ExecuteCommand(string command, params object[] parameters) 		{ 			MobileDatabase.Execute(command, parameters); 		} 	} }