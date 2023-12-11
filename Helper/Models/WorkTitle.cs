using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
	public class WorkTitle
	{
		public int Id { get; set; }
		public string? Name {  get; set; }
		public string? Unit {  get; set; }
		public int WorkTypeId {  get; set; }
		public virtual WorkType? WorkType { get; set; }
		public virtual ICollection<WorkPrice>? WorkPrices { get; set; }
	}
}
