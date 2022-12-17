using nilnul.obj;

namespace nilnul.fs.file.vow.ee_
{
	public class VowDefault<TVow> : file.vow.Ee1
		where TVow : nilnul.fs.file.VowI, new()
	{
		public VowDefault(FileI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
