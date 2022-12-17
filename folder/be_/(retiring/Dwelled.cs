using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_.folder.be_
{
	public class Dwelled
		: BeI
	{
		public bool be(Folder obj)
		{
			return System.IO.Directory.EnumerateFileSystemEntries(obj.ToString()).Any();


			//throw new NotImplementedException();
		}

		static public readonly Dwelled Singleton = SingletonByDefault<Dwelled>.Instance;

		public static bool _Be(string selectedPath)
		{
			return Singleton.be(new Folder(selectedPath));

			//throw new NotImplementedException();
		}
	}
}
