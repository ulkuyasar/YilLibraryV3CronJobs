using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public TEntity Add(TEntity entity)
		{
			using (var context = new TContext())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
				return entity;
			}
		}

		public void Add(List<TEntity> entities)
		{
			using (var context = new TContext())
			{
				context.AddRange(entities);
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var delteddEntity = context.Entry(entity);
				delteddEntity.State = EntityState.Deleted;
				context.SaveChanges();

			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null,int maxCount = 100)
		{

			using (var context = new TContext())
			{
				return filter == null
					? context.Set<TEntity>().OrderByDescending(p => p.Id).Take(maxCount).ToList()
					: context.Set<TEntity>().OrderByDescending(p => p.Id).Where(filter).Take(maxCount).ToList();
			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updatedEntity = context.Entry(entity);
				updatedEntity.State = EntityState.Modified;
				context.SaveChanges();
				return entity;
			}
		}
	}
}
