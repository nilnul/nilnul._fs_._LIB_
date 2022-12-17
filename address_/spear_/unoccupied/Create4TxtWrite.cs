using System.IO;

namespace nilnul.fs.address_.spear_.unoccupied
{
	static public class _Create4TxtWriteX
	{
		static public StreamWriter TxtWriter(string path)
		{
			return System.IO.File.CreateText(
				nilnul.fs.address._OverlongX.PrependIfNeed(
					path
				)

				);
		}
		static public StreamWriter TxtWriter(nilnul.fs.address_.SpearI path)
		{
			return TxtWriter(path.ToString());
		}

	}
}
