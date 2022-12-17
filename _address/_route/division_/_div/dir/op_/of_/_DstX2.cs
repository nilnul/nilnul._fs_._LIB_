namespace nilnul.fs._address._route.division_._div.dir.op_.of_
{
	static public class _DstX
	{
		static public DirI CreateFroDst(DstI dst)
		{
			return new Dir(dst.caption);

		}
		static public DirI CreateFroDst(string dst)
		{
			return CreateFroDst(DstA.Parse(dst));
		}



	}
}
