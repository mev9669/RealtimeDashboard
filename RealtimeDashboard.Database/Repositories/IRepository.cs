﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RealtimeDashboard.Database.Repositories
{
	public interface IRepository<T> : IDisposable
	{
		Task<T> Get(Int64 id);

		Task<T> Get(Expression<Func<T, bool>> predicate);

		Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAll();

        Task Add(T entity);

		Task Update(T entity);

		Task Delete(T entity);
	}
}