using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.driveEntry_
{
	public class Element
	{
		private nilnul.fs.address_._driveEntry_.Drive _drive;

		public nilnul.fs.address_._driveEntry_.Drive drive
		{
			get { return _drive; }
			set { _drive = value; }
		}

		private nilnul.fs.address_._driveEntry_.entry_.ElementI _entry;

		public nilnul.fs.address_._driveEntry_.entry_.ElementI entry
		{
			get { return _entry; }
			set { _entry = value; }
		}

		public Element(
			nilnul.fs.address_._driveEntry_.Drive drive
			,
			nilnul.fs.address_._driveEntry_.entry_.ElementI entry

		)
		{
			_drive = drive;
			_entry = entry;


		}

		static public Element Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{

			var lastSlash = nilnul.num.integer.combine_.Max.Eval(
				s.processed.LastIndexOf(
					nilnul.characters_.DirSeperator.Chars.First()
				)
				,
				s.processed.LastIndexOf(
					nilnul.characters_.DirSeperator.Chars.Last()
				)
			)
			;

			return nilnul.fs.address_.driveEntry_.Element.CreateFroContainerDoc(

				s.processed.Substring(0, lastSlash+1)



				,
				s.processed.Substring(lastSlash + 1)

			);


		}
		static public Element CreateFroContainerDoc(
			Container container
			,
			nilnul.fs._address.DstI doc

		)
		{
			return new Element(
				container.drive
				,
				new _driveEntry_.entry_.container.dst.Element(
					new _driveEntry_.entry_.Container(
						container.entry.dsts.Concat(
							new[] {
							doc }
						)
					)
					,
					doc
				)
			);
		}



		public static Element CreateFroContainerDoc(string container, string doc)
		{

			return CreateFroContainerDoc(
				Container.Parse(container)
				,
				new nilnul.fs._address.Dst(doc)
			);

			throw new NotImplementedException();
		}

		static public Element CreateFroContainerDocument(
			Container container
			,
			nilnul.fs._address.Dsts dsts

		)
		{
			return CreateFroContainerDocument(
				container
				,
				 nilnul.fs.address_._driveEntry.Document.CreateFroDsts(dsts)
			)

				;
		}


		static public Element CreateFroContainerDocument(
				Container container
				,
				nilnul.fs.address_._driveEntry.Document document

			)
		{
			return new Element(
				container.drive
				,
				new _driveEntry_.entry_.container.dst.Element(
					new _driveEntry_.entry_.Container(
						container.entry.dsts.Concat(
							document.dsts.Take(document.dsts.Count() - 1)
						)
					)
						,

						document.dsts.Last()




				)
			);
		}




		static public Element Parse(string s)
		{

			return Parse(new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}
		public override string ToString()
		{
			return $"{_drive}{_entry}";
		}
	}
}
