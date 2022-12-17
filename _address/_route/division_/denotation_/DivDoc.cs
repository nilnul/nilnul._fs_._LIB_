using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document_
{

	[Obsolete(nameof(_address.Document))]
	public class DivDoc
		:
		//DivisionI,
		
		DocumentI
	{

		private DivI _div;

		public DivI div
		{
			get { return _div; }
			set { _div = value; }
		}
		private DocNameI _doc;

		public DocNameI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public DivDoc(
			DivI div,
			DocNameI doc
			
		)
		{
			_div = div;
			_doc = doc;
		}

		public DivDoc(string div, string doc)
			:this(Div.Parse(div), DocNameA.Parse(doc))
		{

		}

		public override string ToString()
		{
			return $"{_div}{_doc}";
		}

		static public DivDoc Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);

			

			return new DivDoc(

				Div.CreateFroDsts(split.Take(split.Length - 1))
				,
				nilnul.fs._address.DocNameA.Parse(split.Last())
			);

		}




	}
}
