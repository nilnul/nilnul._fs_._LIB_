namespace nilnul.fs.folder.dir.op_.unary_
{
	static public class _RenameX
	{
		static public void Void(nilnul.fs.folder_.ParentDir parentDir, nilnul.fs._address._dst.Denote newName)
		{
			System.IO.Directory.Move(
				parentDir.ToString(),
				new nilnul.fs.address_.shield_.BaseDir(parentDir.en.parent, newName).ToString()
			);
		}

		static public void _Void_ofAddressAndNames(string pareng, string dir, string newDir)
		{
			Void(
				nilnul.fs.folder_.ParentDir.OvParentAddress_ChildDenote(pareng, dir)
				,
				new _address._dst.Denote(newDir)
			);
		}
	}
}
