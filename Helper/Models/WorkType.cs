using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
	public class WorkType
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual ICollection<WorkTitle>? WorkTitles { get; set; }
	}
}
