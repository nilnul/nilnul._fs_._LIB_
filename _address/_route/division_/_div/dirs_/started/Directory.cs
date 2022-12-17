using nilnul.fs._address.dir.str_;
using System.Linq;

namespace nilnul.fs._address.dirs_.started
{
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	public class Directory
		:
		nilnul.obj.Box<Started>,
		DirectoryI
	{
		public Directory(Started val) : base(val)
		{

		}

		//public DirsI dirs
		//{
		//	get
		//	{
		//		return new Dirs(
		//			boxed.toArr()
		//		);
		//		throw new NotImplementedException();
		//	}
		//}

		public SeqI dirs => new nilnul.fs._address.dir.str_.Seq(boxed.toArr());

		public override string ToString()
		{
			return nilnul.txts.accumulate_.Join.Singleton.accumulate(
				boxed.toArr().Select(x => x.ToString() + System.IO.Path.PathSeparator)
			);
		}


	}
}
