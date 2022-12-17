namespace nilnul.fs.folder_.tmp.denote_.mainVered_
{
	static public class _NextX
	{
		static public string Txt(string prefix, string ext)
		{
			return new nilnul.fs.folder.denote_.MainVered(nilnul.fs.folder_._TmpX.Ensure()).next(prefix, ext)
			;
		}

		static public string Txt(string doc)
		{
			return new nilnul.fs.folder.denote_.MainVered(nilnul.fs.folder_._TmpX.Ensure()).next(doc)
			;
		}

		static public nilnul.fs.address_.SpearI Spear(string prefix, string ext)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(
				nilnul.fs.folder_._TmpX.Get().address.en, Txt(prefix, ext)
			);
		}

		static public nilnul.fs.address_.SpearI Spear(string doc)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(
				nilnul.fs.folder_._TmpX.Get().address.en, Txt(doc)
			);
		}

		static public string SpearTxt(string doc)
		{
			return Spear(doc).ToString();
		}
		static public string SpearTxt(string main, string ext)
		{
			return Spear(main,ext).ToString();
		}



	}
}
