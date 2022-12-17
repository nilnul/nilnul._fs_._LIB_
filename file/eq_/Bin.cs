using nilnul.fs.address_;
using System.IO;
using F = nilnul.fs.FileI;

namespace nilnul.fs.file.eq_
{
	/// <summary>
	/// the blob is eq
	/// </summary>
	public class Binary : EqI
	//IEqualityComparer<nilnul.fs.FileI>
	,
		nilnul.txt.EqI
		,
		nilnul.fs.address_.spear.EqI
	{
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


		static public bool EqOfDoc(string containerAddress, string doc, string doc1)
		{
			return Singleton.Equals(
				 nilnul.fs.address_.shield._DocX.Spear_ofParentAddress(
					 containerAddress
					 ,
					doc
				)
				,
				 nilnul.fs.address_.shield._DocX.Spear_ofParentAddress(
					(containerAddress)
					 ,
					doc1
				)

			);
		}
		public bool Equals(FileI first, FileI second)
		{
			if (nilnul.fs.address_.spear.Eq.Singleton.Equals(first.file.en, second.file.en))
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


		public int GetHashCode(F obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		public bool Equals(string x, string y)
		{
			return Equals(
				new nilnul.fs.address_.Spear(x)
				,
				new nilnul.fs.address_.Spear(y)
			);
			throw new System.NotImplementedException();
		}

		public int GetHashCode(string obj)
		{
			return 1;
			throw new System.NotImplementedException();
		}

		public bool Equals(SpearI x, SpearI y)
		{
			return Equals(new nilnul.fs.File(x), new nilnul.fs.File(y));
		}

		public int GetHashCode(SpearI obj)
		{
			return 1;
			throw new System.NotImplementedException();
		}
		static public Binary Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Binary>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Binary>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Binary>' is obsolete: 'nilnul.obj_.'
			}
		}
	}
}
