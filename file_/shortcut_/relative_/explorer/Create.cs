using nilnul.fs._address.divDivision;
using nilnul.fs.address_;

namespace nilnul.fs.file_.shortcut_.relative_.explorer
{
	static public class _CreateX
	{
		static public void Create(
			nilnul.fs.address_.ShieldI shield
			,
			_address.doc_._exted.Main main
			,
			nilnul.fs._address.divDivision.RelPathI relPath
		)
		{
			shortcut._CreateX.Create(
				shield
				,
				main
				,
				$@"%windir%\explorer.exe"
				,
				$@"""{relPath.ToString()}"""
			);
		}
		static public void Create(
			nilnul.fs.address_.ShieldI shield
			,
			_address.doc_._exted.Main main
			,
			nilnul.fs.address.co._traject.IShortcut relPath
		)
		{
			shortcut._CreateX.Create(
				shield
				,
				main
				,
				$@"%windir%\explorer.exe"
				,
				$@"""{relPath.ToString()}"""
			);
		}


		public static void Create(ShieldI shield, string main, RelPathI relPath)
		{
			Create(
				shield
				,
				new _address.doc_._exted.Main(main)
				,
				relPath
			);
		}

		public static void Create(ShieldI shield, string main, nilnul.fs.address.co._traject.IShortcut relPath)
		{
			Create(
				shield
				,
				new _address.doc_._exted.Main(main)
				,
				relPath
			);
		}

	}
}
