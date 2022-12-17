using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.eq_
{
	/// <summary>
	/// the blob is eq
	/// </summary>
	/// 
	[Obsolete()]
	public class Binary : EqI
		//IEqualityComparer<nilnul.fs.FileI>
	{
		public bool Equals(FileI first, FileI second)
		{
			if (nilnul.fs.address_.element.Eq1.Singleton.Equals(first.address.en, second.address.en))
			{
				return true;
			}

			return Equals(
				new FileInfo(first.ToString())
				,
				new FileInfo(second.ToString())
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

		static public Binary Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Binary>.Instance;
			}
		}


		static public bool EqOfDoc(string containerAddress, string doc, string doc1)
		{
			return Equals(
				 nilnul.fs.address_.container._DocX.CreateElement(
					 containerAddress
					 ,
					doc
				)
				,
				 nilnul.fs.address_.container._DocX.CreateElement(
					(containerAddress)
					 ,
					doc1
				)

			);
		}
	}
}
