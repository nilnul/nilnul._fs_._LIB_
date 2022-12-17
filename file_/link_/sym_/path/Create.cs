using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.link_.sym_.path
{
	/// <summary>
	/// create symlink, the target of which is a path that can be relative
	/// </summary>
	static public class _CreateX
	{

		public static void Create(SpearI link, nilnul.fs.IPath target)
		{
			//Create(new ShieldDoc1(link), target);
			nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(
				link.ToString()
				,
				target.ToString()
			);

			//throw new NotImplementedException();
		}

		public static void CreateUsingPath(SpearI link, nilnul.fs.address_.SpearI target)
		{

			Create(
				link,
				nilnul.fs.address_.spear.co._RelPathX.Path_froContainer(link, target)
			); ;
			
		}

	}
}
