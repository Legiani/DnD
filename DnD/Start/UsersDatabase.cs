﻿using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace DnD
{
	public class UsersDatabase
	{
		
		private SQLiteAsyncConnection database;

		public UsersDatabase(string dbPath)
		{
			
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<User>().Wait();
		}

		public Task<List<User>> GetItemsAsync()
		{
			return database.Table<User>().ToListAsync();
		}

		public Task<List<User>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<User>("SELECT * FROM [User] WHERE [Done] = 0");
		}

		public Task<User> GetItemAsync(int id)
		{
			return database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(User item)
		{
			
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else
			{
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(User item)
		{
			return database.DeleteAsync(item);
		}
	}
}
