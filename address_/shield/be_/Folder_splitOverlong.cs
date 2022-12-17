using System;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.address_.shield.be_
{
	[Obsolete(nameof(_FolderX_prefixIfNeed),true)]
	static public class _FolderX
	{
		const int MAX_LENGTH = 260;

		public static bool Be(nilnul.fs.address_.ShieldI path)
		{
			nilnul.fs.address_.ShieldI basis = new nilnul.fs.address_.shield_.Vol1(path.vol);
			if (!nilnul.fs.address_.shield_.notOverlong.be_.Folder.Singleton.be(basis))
			{
				return false;
			}

			var dirs = path.stem.div.dirs.ToArray();

			int i = 0;

			//grow before over MaxLength
			for (; i < dirs.Length; i++)
			{
				var candidate = new nilnul.fs.address_.shield_.BaseDir(basis, dirs[i]);
				if (candidate.ToString().Length >= MAX_LENGTH)
				{
					break;
				}

				basis = candidate;
			}

			if (!nilnul.fs.address_.shield_.notOverlong.be_.Folder.Singleton.be(basis))
			{
				return false;
			}

			var basisForOverlong = nilnul.fs.address_.shield.to_._InfoX.Info(basis);

			for (; i < dirs.Length; i++)
			{

				basisForOverlong = basisForOverlong.EnumerateDirectories().FirstOrDefault(
					x => nilnul.fs._address._dst.denote.Eq.Singleton.eq(
						x.Name, dirs[i].denote
					)
				);
				if (basisForOverlong is null)
				{
					return false;
				}

			}

			return true;



		}

		public static bool Be(string path)
		{

			return Be(
				nilnul.fs.address_.Shield.FroAddress(path)
			); ;

		}


	}


}
