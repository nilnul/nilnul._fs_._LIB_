using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._dst.name.be_
{
	[Obsolete()]
	public class Valid : nilnul.txt.BeI
	{
		


		static public nilnul.txt.be_.NotContain NotContainInvalidChars= new nilnul.txt.be_.NotContain(_denote.txt.be_._valid.cha_.Invalids.Lazy);
		



		

		public bool be(string obj)
		{

			return
				obj.Length>0 
				&&
				 nilnul.fs._address._dst.denote.be_._valid.headTip.be_._ValidX.Be(obj.First())
				

				&&
				 nilnul.fs._address._dst.denote.be_._valid.headTip.be_._ValidX.Be(obj.Last())
				&&
				NotContainInvalidChars.be(obj) 
				&&
				
				!_denote.txt.be_._valid.InvalidNames.Singleton.contains(obj)
			;
		}


		static public Valid Singleton
		{
			get
			{
				return nilnul.Singleton1<Valid>.Instance;
			}
		}
		[Obsolete()]
		public class En:nilnul.obj.be.En_beDefaultable<string,Valid>
		{
			public En(string s):base(s)
			{

			}

		}
	}
}
