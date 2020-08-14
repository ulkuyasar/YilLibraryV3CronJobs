using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.NHibernate
{
	public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
	{

		protected NHibernateHelper _nHibernateHelper;

		public NhEntityRepositoryBase(NHibernateHelper nHibernateHelper)
		{
			_nHibernateHelper = nHibernateHelper;
		}

		public TEntity Add(TEntity entity)
		{
			using (var session = _nHibernateHelper.OpenSession())
			{
				session.Save(entity);
				return entity;
			}
		}

		/// <summary>
		/// bunu daha sonra ıyılestırmelısın
		/// </summary>
		/// <param name="entities"></param>
		public void Add(List<TEntity> entities)
		{

			foreach (var item in entities)
			{
				Add(item);
			}
		}

		public void Delete(TEntity entity)
		{
			using (var session = _nHibernateHelper.OpenSession())
			{
				session.Delete(entity);
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var session = _nHibernateHelper.OpenSession())
			{
				return session.Query<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, int maxCount =100)
		{
			using (var session = _nHibernateHelper.OpenSession())
			{
				return filter == null
					? session.Query<TEntity>().Take(maxCount).ToList()
					: session.Query<TEntity>().Where(filter).Take(maxCount).ToList();
			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var session = _nHibernateHelper.OpenSession())
			{
				session.Update(entity);
				return entity;
			}
		}
	}
}
