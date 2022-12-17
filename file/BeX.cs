using System.IO;

namespace nilnul.fs.file
{
	static public class BeX
	{

		static public bool Be(this nilnul.fs.file.BeI be, nilnul.fs.File obj)
		{
			return be.be((nilnul.fs.FileI)obj);
		}

		static public bool Be(this nilnul.fs.file.BeI be, FileInfo obj)
		{
			return Be(be, new nilnul.fs.File(obj));
		}

		static public bool Be(this nilnul.fs.file.BeI be, nilnul.fs.address_.SpearI obj)
		{
			return Be(be, new nilnul.fs.File(obj));
		}

		static public bool Be(this nilnul.fs.file.BeI be, string obj)
		{
			return Be(
				be
				,
				nilnul.fs.address_.Spear.Parse(obj)
			);
		}

	}
}
