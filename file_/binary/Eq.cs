using System.Collections.Generic;
using System.IO;

namespace nilnul.fs.file_.binary
{
	public class Eq : IEqualityComparer<nilnul.fs.FileI>
	{
		public bool Equals(FileI first, FileI second)
		{
			if (nilnul.fs.file.eq_.ByAddress.Singleton.Equals(first, second))
			{
				return true;
			}

			return Equals(
				nilnul.fs.file.to_.ToFileInfo.Singleton.to(
				first
				)
				,
				nilnul.fs.file.to_.ToFileInfo.Singleton.to(
				second
				)

			);

			//throw new NotImplementedException();
		}


		static bool Equals(FileInfo first, FileInfo second)
		{
			if (first.Length != second.Length)
				return false;

			//if (first.FullName == second.FullName)
			//	return true;

			using (FileStream fs1 = first.OpenRead())
			using (FileStream fs2 = second.OpenRead())
			{
				for (int i = 0; i < first.Length; i++)
				{
					if (fs1.ReadByte() != fs2.ReadByte())
						return false;
				}
			}

			return true;
		}

		public int GetHashCode(FileI obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

		static public bool EqOfDoc(string containerAddress, string doc, string doc1)
		{
			var parent = address_.Shield.FroAddress(containerAddress);
			return Equals(
				 nilnul.fs.address_.shield._DocX.Spear(
					parent
					 ,
					doc
				)

				,
				 nilnul.fs.address_.shield._DocX.Spear(
					 parent
					 ,
					doc1
				)

			);
		}
	}
}
