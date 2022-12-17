using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.address_.spear
{
	static public class _DocX
	{
		static public string _Name(string _spear)
		{
			var lastSlash = _spear.LastIndexOfAny(_address._route_._SeparatorX.Chars);

			return _spear.Substring(lastSlash + 1);
		}
		static public string __Txt(string _spear)
		{
			var lastSlash = _spear.LastIndexOfAny(_address._route_._SeparatorX.Chars);

			return _spear.Substring(lastSlash + 1);
		}

		[Obsolete()]
		static public string _Txt(string _spear)
		{

			return __Txt(_spear);
		}



		public static DocI Doc(SpearI spear)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(spear).doc;
			//throw new NotImplementedException();
		}
		public static DocI Doc(string spear)
		{
			return Doc(nilnul.fs.address_.Spear.Parse(spear));
			//throw new NotImplementedException();
		}
		public static nilnul.fs._address.DocI Doc(FileInfo info)
		{
			return Doc((nilnul.fs.address_.Spear)info);
			//throw new NotImplementedException();
		}

	}
}
