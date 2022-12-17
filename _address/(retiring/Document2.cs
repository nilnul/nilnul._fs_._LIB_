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
	public class Document2
		:
		//DivisionI,
		
		DocumentI2
	{

		private DivI1 _div;

		public DivI1 div
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

		public Document2(
			DivI1 div,
			DocI doc
			
		)
		{
			_div = div;
			_doc = doc;
		}

		public Document2(string div, string doc)
			:this(Div1.Parse(div), DocA.Parse(doc))
		{

		}

		

		

		public override string ToString()
		{
			return $"{_div}{_doc}";
		}

		static public Document2 Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);

			

			return new Document2(

				Div1.CreateFroDsts(split.Take(split.Length - 1))
				,
				nilnul.fs._address.DocA.Parse(split.Last())
			);

		}
		





	}
}
