using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.full_.tipped_
{
	

	public class DntEnd
		:
		FullI
		,
		_address_.VolI

	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs.path_.contextual_.rted_.tipped_.DntEnded _route;

		public nilnul.fs.path_.contextual_.rted_.tipped_.DntEnded route
		{
			get { return _route; }
			set { _route = value; }
		}

		public DntEnd(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs.path_.contextual_.rted_.tipped_.DntEnded route

		)
		{
			_vol = vol;
			_route = route;


		}

		public nilnul.fs.address_.Spear toSpear()
		{
			try
			{
				return new nilnul.fs.address_.Spear(this._vol
					,
					this._route.toSprig()
				);

			}
			catch (route_.xpn_.AboveRtException e)
			{

				throw new path_.full_.xpn_.AboveRtException($"{this} when converted to literal, there are some ups resulting the address above the vol root", e);
			}
		}

		

		public override string ToString()
		{
			return $"{_vol}{_route}";
		}

		static public DntEnd Parse(string s)
		{
			var colonAddress = s.IndexOf(':');
			var colonIndexPlus = colonAddress + 1;


			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, colonIndexPlus));


			var route = path_.contextual_.rted_.tipped_.DntEnded.Parse(s.Substring(colonIndexPlus));

			return new DntEnd(vol, route);
		}





		


	}

}
