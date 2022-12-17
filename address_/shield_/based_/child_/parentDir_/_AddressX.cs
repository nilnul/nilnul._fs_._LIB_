using System.Linq;

namespace nilnul.fs.address_.shield_.parentDir_
{
	static public class _AddressX
	{
		static public nilnul.fs.address_.shield_.BaseDir Create(string address)
		{

			var shield = Shield.Parse(address);

			var dirs = shield.stem.div.dirs;


			return new BaseDir(
				new nilnul.fs.address_.Shield(shield.vol, dirs.Take(dirs.Count() - 1))
				,
				dirs.Last()
			);


		}
	}
}
