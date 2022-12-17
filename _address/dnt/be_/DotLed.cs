using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dnt.be_
{
	/// <summary>
	/// eg:
	///		.git
	///		.nilnul
	///	often means a hidden folder for settings used by a specific software. Human intervention is not need or allowed.
	///	so in nilnul.dev, only non dotLed folder/file are considered the crop of a programmer.
	/// </summary>
	/// alias:
	///		dotLed
	///		bot
	///			not artifact.
	///			used by bot.
	public class DotLed
		:
		nilnul.fs._address._route.division_._div._dir.dnt.BeI
		,
		nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return obj.StartsWith(".");

		}
		public bool be(_route.division_._div._dir.Dnt obj)
		{
			return be(obj.en);
		}
		public bool be(_route.division_._div._dir.DntI obj)
		{
			return obj switch {
				_route.division_._div._dir.Dnt dnt => be(dnt)
				,
				_ =>be(obj.caption)
			};
		}

		static public DotLed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<DotLed>.Instance;
			}
		}


	}
}
