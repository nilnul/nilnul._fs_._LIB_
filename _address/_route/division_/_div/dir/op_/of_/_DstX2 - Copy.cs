namespace nilnul.fs._address.dir_
{
	static public class _DstX
	{
		static public DirI CreateFroDst(DstI dst)
		{
			return new Dir(dst.denote);

		}
		static public DirI CreateFroDst(string dst)
		{
			return CreateFroDst(DstA.Parse(dst));
		}



	}
}
