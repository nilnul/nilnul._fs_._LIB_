using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{

	/// <summary>
	/// div and doc
	/// </summary>
	/// 
	[Obsolete()]
	public class Document1
		:
		//DivisionI,
		
		DocumentI1
	{

		private DivI _div;

		public DivI div
		{
			get { return _div; }
			set { _div = value; }
		}
		private DocI _doc;

		public DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public Document1(
			DivI div,
			DocI doc
			
		)
		{
			_div = div;
			_doc = doc;
		}

		public Document1(string div, string doc)
			:this(Div.Parse(div), DocA.Parse(doc))
		{

		}


		public override string ToString()
		{
			return $"{_div}{_doc}";
		}

		static public Document1 Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);

			

			return new Document1(

				Div.CreateFroDsts(split.Take(split.Length - 1))
				,
				nilnul.fs._address.DocA.Parse(split.Last())
			);

		}




	}
}
