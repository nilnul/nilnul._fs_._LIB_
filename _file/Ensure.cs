using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.spear_;

namespace nilnul.fs._file
{
	static public class _EnsureX
	{

		static public void _Ensure_assumeParentExist_pathIsNotPrependedWithOverlongQuad(string s)
		{
			using (var f = System.IO.File.CreateText(@"\\?\" + s))
			{

			}
			;
		}
		public static void Ensure(nilnul.fs.address_.spear_.ParentDoc folder2be)
		{
			nilnul.fs.folder._EnsureX.Void(
				folder2be.parent);
			_Ensure_assumeParentExist_pathIsNotPrependedWithOverlongQuad(folder2be.ToString());
		}

		public static void Ensure(ParentDocument folder2be)
		{
			Ensure(new ParentDoc(folder2be));
		}
	}
}
