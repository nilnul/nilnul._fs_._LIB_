using nilnul.fs._address._dst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.denotation_.divDoc_
{

	/// <summary>
	/// </summary>
	///
	[Obsolete()]
	public class DenotesDoc
		:


		DocumentI
	{
		private nilnul.fs._address._dst.denote.str_.seq.Join _denotes;
		public nilnul.fs._address._dst.denote.str_.seq.Join denotes
		{
			get { return _denotes; }
			set { _denotes = value; }
		}
		private DocI _doc;
		public DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public DivI div => _denotes.toDiv();

		public DenotesDoc(
			nilnul.fs._address._dst.denote.str_.seq.Join div,
			DocI doc
		)
		{
			_denotes = div;
			_doc = doc;
		}
		public DenotesDoc((IEnumerable<IDnt>, IDnt) p):this(p.Item1,p.Item2)
		{
		}

		public DenotesDoc(IEnumerable< _address.IDnt> dnts)
			:this( nilnul.obj.str_.started._TorsoTipX.TorsoTip(dnts))
		{

		}

		public DenotesDoc(
			DocI doc
			) : this(
				new nilnul.fs._address._dst.denote.str_.seq.Join()
				, doc
			)
		{
		}

		public DenotesDoc(string dsts, string doc)
			: this(nilnul.fs._address._dst.denote.str_.seq.Join.Parse2Str(dsts), new Doc(doc))
		{
		}

		public DenotesDoc(IEnumerable<Denote> enumerable, DocI doc) : this(new _dst.denote.str_.seq.Join(enumerable), doc)
		{

		}

		public DenotesDoc(IEnumerable<IDnt> item1, IDnt item2)
			:this(
				 new nilnul.fs._address._dst.denote.str_.seq.Join(item1.Select(x=>x.ToString()))
				 ,
				 new _address.Doc(
				 item2.ToString()
				 ) as DocI
			)
		{
		}




		public Document toDocument()
		{
			return new Document(
				this.denotes.toDiv()
				, this.doc
			);
		}


		public override string ToString()
		{
			return toDocument().ToString();
		}

		static public DenotesDoc Parse(string txt)
		{
			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);
			return new DenotesDoc(

				new _dst.denote.str_.seq.Join(split.Take(split.Length - 1))
				,
				new nilnul.fs._address.Doc(split.Last())
			);
		}
	}
}