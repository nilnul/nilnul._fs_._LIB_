using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	public class Dsts :
		nilnul.objs_.List<DstI>
		,
		DstsI

	{

		public Dsts(IEnumerable<DstI> val) : base(val.ToList())
		{
		}

		public Dsts(IEnumerable<string> dsts) : this(dsts.Select(d => DstA.Parse(d)))
		{

		}
		public Dsts() : this(new DstA[0])
		{

		}



		public override string ToString()
		{
#pragma warning disable CS0612 // 'Path' is obsolete
			return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(this.Select(x => x.ToString()));
#pragma warning restore CS0612 // 'Path' is obsolete
		}

		public DstI[] toArr()
		{
			return this.ToArray();
			//throw new NotImplementedException();
		}

		//[Obsolete(nameof(Destination.Parse))]
		//static public Dsts Parse(string x) {
		//	return new Dsts(
		//		x.Split(

		//			nilnul.characters_.DirSeperator.Chars

		//		).Select(y=> new Dst(y))
		//	);
		//}

		//static public Dsts CreateFroDsts(IEnumerable<string> dsts) {
		//	return new Dsts(
		//		dsts.Select(x=> new DstA(x) )
		//	);
		//}

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
