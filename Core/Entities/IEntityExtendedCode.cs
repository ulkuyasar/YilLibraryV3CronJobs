using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
	public class IEntityExtendedCode : IEntity, IEquatable<IEntityExtendedCode>
	{
		public  string Code { get; set; }
		//public  DateTime CreatedDate { get; set; }
		//public  DateTime? UpdatedDate { get; set; }
		//public string CreatedUser { get; set; }
		//public string UpdatedUser { get; set; }
		//public Int32 WhichPageId { get; set; }
		//public bool RecordStatus { get; set; }
		public bool Equals(IEntityExtendedCode other)
		{
			if (other != null)
			{
				if (other.Code.Equals(this.Code))
				{
					return true;
				}
			}
			return false;
		}

		[NotMapped]
		public long? Id { get { return id; } set { id = value; } }
		private long? id;
	}
}
