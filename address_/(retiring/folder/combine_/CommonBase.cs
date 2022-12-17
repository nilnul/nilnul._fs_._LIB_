using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.folder.combine_
{
	/// <summary>
	/// find the common base of a duo of folders
	/// </summary>
	public class CommonBase
	{
		[ReturnNull]
		static public Folder Eval_retNullable(Folder a, Folder b) {

			if (nilnul.fs._address.root.Eq.Singleton.Equals( a.root,b.root) )
			{
				return new Folder(a.root, 

					_address.stem.duo.CommonBase.Eval(a.stem,b.stem)
					
				);
			}
			else
			{
				return null;
			}
		}
	}
}
