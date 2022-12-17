namespace nilnul.fs.file.move
{
	static public class _SoftLinkRemainX
	{
		static public void Void(
			nilnul.fs.FileI src
			,
			nilnul.fs.address_.SpearI dst
		)
		{
			_MoveX.Void(src, dst);
			file_._SymlinkX.Create(src.file.en, dst);
		}

		static public void Void(string src, string dst)
		{
			Void(
				new nilnul.fs.File(src)
				,
				new nilnul.fs.address_.Spear(dst)
			);
		}
	}
}