using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a folder.
	/// </summary>
	/// 
	[Obsolete()]
	public class FolderFormatAndExists : BeI
	{
		public bool be(Address obj)
		{
			return be_.Container.Singleton.be(obj)
				&&
				System.IO.Directory.Exists(obj.ToString())	///note: there may or may not be trailing slash
			; 
		}


		static public readonly FolderFormatAndExists Singleton = nilnul.obj.SingletonByDefault<FolderFormatAndExists>.Instance;

	}
}
