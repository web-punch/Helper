using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
	public class Work
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; } = DateTime.Now;
		public string? Address {  get; set; }
		public double Amount { get; set; }
		public int WorkPriceId {  get; set; }
		public virtual WorkPrice? WorkPrice { get; set; }
		public string Print
		{
			get
			{
				return $"{DateTime.ToShortDateString()}{Address}";
			}
		}

		//
		// Для сравнения объектов Work нужно переопределить метод Equals
		// Здесь объекты Work сравниваются исходя из значения их свойств DateTime и Address - если дата и адрес равны, то и объекты Work равны.
		//
		public override bool Equals(object? obj)
		{
			if (obj is Work work)
			{
				return DateTime == work.DateTime && Address == work.Address;
			}
			return false;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(DateTime, Address);
		}
	}
}
