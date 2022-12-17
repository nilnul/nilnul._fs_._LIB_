using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.file.duo.route_
{
	/// <summary>
	/// 
	/// </summary>
	/// todo: allow "."; allow ".",".." in the middle
	public class Rel:RouteI
	{

		private address.duo.route_._rel.Parents _parents;

		public address.duo.route_._rel.Parents parents
		{
			get { return _parents; }
			//set { _parents = value; }
		}



		private _address.sprig_.File _sprig;

		public _address.sprig_.File sprig
		{
			get { return _sprig; }
			//set { _stem = value; }
		}


		public Rel(address.duo.route_._rel.Parents parents, _address.sprig_.File sprig)
		{
			_parents = parents;
			_sprig = sprig;
		}

		public override string ToString()
		{
			if (_parents.vals.Count()==0)
			{
				return $"{_sprig}";
			}

			return $"{_parents}{nilnul.fs._address.Separator.AsTxt}{_sprig}";
		}


		static public Rel Parse(string txt) {

			var split = txt.Split(nilnul.fs._address.Separator.AsChar);

			var sprigPart=split.SkipWhile( x=> _rel.Parent.IsParent(x));

			return new Rel(
				address.duo.route_._rel.Parents.CreateFroCount(split.Count()-sprigPart.Count())
				,
				nilnul.fs._address.sprig_.File.Parse(sprigPart)
			);



			
		}

	}
}
