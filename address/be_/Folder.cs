using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a folder. the address may be container  or tipped.
	/// </summary>
	public class Folder : BeI
	{
		public bool be(Address obj)
		{
			return System.IO.Directory.Exists(obj.toFolderLike().ToString())	///note: there may or may not be trailing slash
			; 
		}


		static public readonly Folder Singleton = nilnul.obj.SingletonByDefault<Folder>.Instance;

	}
}
