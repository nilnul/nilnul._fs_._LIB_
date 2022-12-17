using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks> 
	/// alias: path
	/// </remarks>
	/// 
	[Obsolete("this shall be abstract")]
	public class Route : RouteI
	{
		private DivisionI _division;

		public DivisionI division
		{
			get { return _division; }
			//set { _division = value; }
		}



		//[Obsolete()]
		public Route(DivisionI division)
		{
			_division = division;
		}

		static public Route FroDirs(IEnumerable<DirI> dirs) {
			return new Route(
				Div.CreateFroDirs(dirs)
			);
		}

		static public Route Parse(string s)
		{
			Deck.Vow(s.First(), new ArgumentException($"route must start with {Deck.ToChar()} or {System.IO.Path.AltDirectorySeparatorChar}."));

			return new Route(
				DivisionX.Parse(s.Substring(1))
			);
			






		}



		public override string ToString()
		{
			
			return $"{Deck.ToTxt()}{_division}"
			;
		}


	
	}
}
