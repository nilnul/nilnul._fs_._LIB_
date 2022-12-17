using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{
	/// <summary>
	/// "a", "a\b"
	/// exclude:
	///		"", "a\", "a\b\"
	/// </summary>
	/// 
	[Obsolete(nameof(document_.DivDoc))]
	public class Document:DestinationI
	{

		private nilnul.fs._address.dsts_.Started _dsts;

		public nilnul.fs._address.dsts_.Started dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}

		public Document(nilnul.fs._address.dsts_.Started dsts)
		{
			_dsts = dsts;

		}

		static public Document CreateFroDsts(
			IEnumerable<nilnul.fs._address.DstI> dsts	
		) {
			return new Document(
				 _address.dsts_.Started.CreateFroDsts(dsts)
			);
		}

		static public Document CreateFroDirectoryDoc(
			Directory directory
			,
			nilnul.fs._address.DstI dst
			
		) {

			return new Document(
				 _address.dsts_.Started.CreateFroDsts(
					directory.dsts.Concat( new[] { dst})
				)
			);

		}
		public override string ToString()
		{
			return nilnul.txts.accumulate_.Join.Singleton.accumulate(
				_dsts.Select(x=>x.ToString()+ System.IO.Path.PathSeparator)
			);
		}

		public static Document CreateFroDirectoryDoc(Directory directory, string doc)
		{
			return CreateFroDirectoryDoc(
				directory,
				new nilnul.fs._address.DstA(doc)
			);
			throw new NotImplementedException();
		}

		public static Document CreateFroDirectoryDoc(string sTEM_since_Base, string dOC)
		{

			return CreateFroDirectoryDoc(
				Directory.Parse(sTEM_since_Base)
				,
				new nilnul.fs._address.DstA(dOC)
			);
			throw new NotImplementedException();
		}

	

	}
}
