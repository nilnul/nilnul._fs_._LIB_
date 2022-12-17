using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using System.IO;

namespace nilnul.fs.address_.volRoute_
{
	[Obsolete()]

	public class Container : ContainerI
	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		private nilnul.fs._address.route_.DeckedDiv _deckedDiv;

		public nilnul.fs._address.route_.DeckedDiv deckedDiv
		{
			get { return _deckedDiv; }
			set { _deckedDiv = value; }
		}

		public RouteI route
		{
			get
			{
				return _deckedDiv;
				throw new NotImplementedException();
			}
		}

		public Container(
			nilnul.fs._address.VolI vol
			,
			nilnul.fs._address.route_.DeckedDiv deckedDiv

		)
		{
			_vol = vol;
			_deckedDiv = deckedDiv;


		}

		static public Container Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
			return new Container(
				_address.Vol.Parse_fromTrimmed(s.processed.Substring(0, 2))
				,
				nilnul.fs._address.route_.DeckedDiv.Parse(s.processed.Substring(2))
			);
		}



		static public Container CreateFroContainerDiv(
				Container container
				,
				nilnul.fs._address.DivI div

			)
		{
			return new Container(
				container.vol
				,
				new _address.route_.DeckedDiv(

					nilnul.fs._address.div.combine_.Concat.Singleton.eval(
						container.deckedDiv.div
						,
						div

					)
				)
			);
		}



		static public Container Parse(string s)
		{

			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}

		static public ContainerI CreateFroVolRoute(string s)
		{
			return VolRouteIX.ToContainer(VolRouteIX.Parse(s));
		}
		public override string ToString()
		{
			return $"{_vol}{_deckedDiv}";
		}

		static public implicit operator Container(DirectoryInfo dirInfo) {
			return Container.Parse(dirInfo.ToString());
		}
	}
}
