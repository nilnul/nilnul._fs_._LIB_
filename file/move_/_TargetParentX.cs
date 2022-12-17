namespace nilnul.fs.file.move_
{
	static public class _TargetParentX
	{
		static public void Void(nilnul.fs.FileI src, nilnul.fs.address_.ShieldI dst)
		{

			var srcParentChild = new nilnul.fs.address_.spear_.ParentDoc(src.file.en);
			_MoveX.Void(
				src
				,
				new nilnul.fs.address_.spear_.ParentDoc(
					srcParentChild.parent
					,
					srcParentChild.doc
				)
			);
		}
	}
}
