namespace nilnul.fs.file
{
	static public class _MoveX
	{
		static public void Void(nilnul.fs.FileI src, nilnul.fs.address_.SpearI dst)
		{
			System.IO.File.Move(src.ToString(), dst.ToString());
		}
	}
}
