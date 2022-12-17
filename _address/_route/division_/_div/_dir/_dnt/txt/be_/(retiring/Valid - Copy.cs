using System;

namespace nilnul.fs._address._dst._denote.txt.be_
{
	[Obsolete()]
	public class Valid : nilnul.txt.BeI
	{

		static public nilnul.txt.be_.NotContain NotContainInvalidChars = new nilnul.txt.be_.NotContain(_valid.cha_.Invalids.Singleton);

		public bool be(string obj)
		{

			return
				//obj.Length>0 
				////&&
				//// nilnul.fs._address._dst.denote.be_._valid.headTip.be_._ValidX.Be(obj.First())


				////&&
				//// nilnul.fs._address._dst.denote.be_._valid.headTip.be_._ValidX.Be(obj.Last())
				//&&
				NotContainInvalidChars.be(obj)
				&&

				!_valid.InvalidNames.Singleton.contains(obj)
			;
		}

		static public Valid Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Valid>.Instance;
			}
		}

	}
}
