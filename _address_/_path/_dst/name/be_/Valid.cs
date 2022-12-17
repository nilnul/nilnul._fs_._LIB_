using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path._dst.name.be_
{
	public class Valid : nilnul.txt.BeI
	{
		


		static public nilnul.txt.be_.NotContain NotContainInvalidChars= new nilnul.txt.be_.NotContain(_valid.InvalidChars.Lazy);
		



		

		public bool be(string obj)
		{

			return NotContainInvalidChars.be(obj) 
				&&
				
				!_valid.InvalidTxts.Singleton.contains(obj)
			;
		}

		static public readonly Valid Singleton = SingletonByDefault<Valid>.Instance;

		
	}
}
