using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	[Obsolete()]
	public class Location<T> : nilnul.obj.BeI1<T>
		where T:AddressI1
	{
		public bool be(T obj)
		{
			var txt = obj.ToString();

			return  System.IO.File.Exists(txt) || System.IO.Directory.Exists(txt);
		}


		static public Location Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Location>.Instance;
			}
		}
	}

	
}
