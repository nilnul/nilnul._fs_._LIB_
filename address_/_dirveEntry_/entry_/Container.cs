using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address_._path.dsts_;

namespace nilnul.fs.address_._driveEntry_.entry_
{
	public class Container:EntryA, ContainerI
	{
		private nilnul.fs._address.Dsts _dsts;

		public nilnul.fs._address.Dsts dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}


		public Container(
			nilnul.fs._address.Dsts dsts
		)
		{
			_dsts = dsts;
		}

		public Container(IEnumerable<Dst> enumerable)
			:this( new Dsts(enumerable))
		{

		}

		public Container(IEnumerable<DstI> enumerable)
			:this( new Dsts(enumerable))
		{

		}



		public override string ToString()
		{
			return  System.IO.Path.DirectorySeparatorChar+ nilnul.txts.accumulate_.Join.Singleton.accumulate(_dsts.Select(x=> nilnul.fs._address.DirName.ToTxt(x)));
		}

		public static Container Parse(string sTEM_since_Base)
		{
			nilnul.obj.vow_.True.Vow(
				sTEM_since_Base.EndsWith("\\") || sTEM_since_Base.EndsWith("/")
			);

			return new Container(
				nilnul.fs._address.Dsts.Parse(
					sTEM_since_Base.Substring(0, sTEM_since_Base.Length-1) 
				)
			);

			throw new NotImplementedException();
		}

		public static Container CreateFroDsts(string dsts)
		{

			return new Container(
				nilnul.fs._address.Dsts.Parse(dsts)
			);
			throw new NotImplementedException();
		}
	}
}
