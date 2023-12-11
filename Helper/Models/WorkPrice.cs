using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
	public class WorkPrice
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public double Price { get; set; }
		public int WorkTitleId { get; set; }
		public virtual WorkTitle? WorkTitle { get; set; }
		public virtual ICollection<Work>? Works { get; set; }
		public string Print => $"{WorkTitle?.WorkType?.Name}{WorkTitle?.Name}";
	}
}
