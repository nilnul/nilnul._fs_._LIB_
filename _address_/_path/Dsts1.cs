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
	public class Dsts1 :
		nilnul.objs_.List<DstI>
		,
		DstsI1

	{

		public Dsts1(IEnumerable<DstI> val) : base(val.ToList())
		{
		}

		public Dsts1():this(new Dst[0])
		{

		}

		public override string ToString()
		{
			return String.Join(_SeperatorX.Seperator.ToString(), this);
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
