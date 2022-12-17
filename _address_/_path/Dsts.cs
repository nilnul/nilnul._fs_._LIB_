using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;

namespace nilnul.fs._address_._path
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	[Obsolete()]
	public class Dsts : /*obj::*/nilnul.obj.str_.FiniteEnum<Dst>
		//, IEnumerable<DstI>

	{
		public Dsts(IEnumerable<Dst> val) : base(val)
		{
		}

		public Dsts():this(new Dst[0])
		{

		}

		public override string ToString()
		{
			return String.Join(_SeperatorX.Seperator.ToString(), this.ed);
		}

		//IEnumerator<DstI> IEnumerable<DstI>.GetEnumerator()
		//{
		//	foreach (var item in this)
		//	{
		//		yield return item as DstI;
		//	}
		//	//throw new NotImplementedException();
		//}
	}
}
