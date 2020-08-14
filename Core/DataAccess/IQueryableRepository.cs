using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccess
{
	public interface IQueryableRepository<T> where T : class, Entities.IEntity, new()
	{
		IQueryable<T> Table { get; }
	}
}
