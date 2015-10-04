using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using FileSocialNetwork.Shared.Contracts.DataAccess;

namespace FileSocialNetwork.DataAccess.SqlDataAccess.Repositories
{
	public class BaseRepository<T> : IRepository<T> where T: class
	{
		protected readonly DbContext Context;
		protected readonly DbSet<T> Items;

		public BaseRepository(DbContext context)
		{
			Context = context;
			Items = context.Set<T>();
		}

		#region Implementation of IRepository<T>

		public virtual T Create(T item)
		{
			Items.Add(item);
			return item;
		}

		public virtual T Update(T item)
		{
			Context.Entry(item).State = EntityState.Modified;
			return item;
		}

		public virtual T Delete(int id)
		{
			T item = Items.Find(id);
			if (item != null)
				Items.Remove(item);
			return item;
		}

		public virtual T GetById(int id)
		{
			T result = Items.Find(id);
			return result;
		}

		public virtual IEnumerable<T> GetAll()
		{
			return Items.ToArray();
		}

		public virtual IEnumerable<T> Find(Func<T, bool> predicate)
		{
			IEnumerable<T> result = Items.Where(predicate).ToList();
			return result;
		}

		#endregion
	}
}
