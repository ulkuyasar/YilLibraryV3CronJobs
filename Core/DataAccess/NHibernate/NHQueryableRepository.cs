using Core.Entities;
using System.Linq;


namespace Core.DataAccess.NHibernate
{
	public class NHQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
	{

		private NHibernateHelper _nHibernateHelper;
		private IQueryable<T> _entities;

		public NHQueryableRepository(NHibernateHelper nHibernateHelper)
		{
			_nHibernateHelper = nHibernateHelper;
		}

		public IQueryable<T> Table
		{
			get { return this.Entities; }
		}

		public virtual IQueryable<T> Entities
		{
			get
			{
				return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());
			}
		}


	}
}
