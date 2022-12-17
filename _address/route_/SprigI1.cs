using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_
{
	/// <summary>
	/// there is an separator at the end. sprig. not stem
	/// </summary>
	/// 
	[Obsolete()]
	public interface SprigI1 : RouteI
	{

		_address.DocumentI2 document
		{
			get;
		}

	}
	[Obsolete()]
	public abstract class SprigA : SprigI1
	{
		public abstract DocumentI2 document { get; }
		public  DivisionI division { get { return document; } }
		static public SprigI1 Downcast(RouteI route) {
			switch (route)
			{
				case SprigI1 sprig:
					return sprig;

				default:
					return Sprig2.Parse(route.ToString());
					break;
			}
		}
	}



}