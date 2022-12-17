using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_
{

	public interface FullI
		: IFull
	{ }

	public class Full
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

		private nilnul.fs.path_.Rted _route;

		public nilnul.fs.path_.Rted route
		{
			get { return _route; }
			set { _route = value; }
		}

		public Full(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs.path_.Rted route

		)
		{
			_vol = vol;
			_route = route;


		}

		public nilnul.fs.AddressI toAddress()
		{
			try
			{
				return nilnul.fs.AddressA.Ov(this._vol
					,
					this._route.toRoute()
				);

			}
			catch (route_.xpn_.AboveRtException e)
			{

				throw new path_.full_.xpn_.AboveRtException($"{this} when converted to literal, there are some ups resulting the address above the vol root", e);
			}
		}

		public nilnul.fs.address_.SpearI makeSpear()
		{
			return nilnul.fs.address.to_._SpearX.Spear(toAddress());
		}

		public override string ToString()
		{
			return $"{_vol}{_route}";
		}

		static public Full Parse(string s)
		{
			var colonAddress = s.IndexOf(':');
			var colonIndexPlus = colonAddress + 1;


			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, colonIndexPlus));


			var route = path_.Rted.Parse(s.Substring(colonIndexPlus));

			return new Full(vol, route);
		}





		static public nilnul.fs.address_.SpearI MakeSpear(nilnul.fs._address.VolI vol, Rted rooted)
		{
			return new path_.Full(vol, rooted).makeSpear();



		}


	}

}
