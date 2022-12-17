namespace nilnul.fs.address_.spear
{
	static public class _ContainerX
	{
		static public nilnul.fs.address_.ShieldI Shield(nilnul.fs.address_.SpearI spear)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(spear).parent;
		}
		static public nilnul.fs.address_.ShieldI Shield(string spear)
		{
			return  nilnul.fs.address_.spear_.ParentDoc.Parse(spear).parent;
		}

		static public string TxtUptoLastSep(string spear)
		{
			return spear.Substring(
				0,  spear.LastIndexOfAny( _address._route._SeparatorX.Chars)+1
				);
		}

	}
}
