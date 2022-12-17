using nilnul.fs._address.dir.str_;
using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address
{
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	///
	[Obsolete()]
	public class Directory
		:
		nilnul.fs._address.dir.str_.seq.Started,
		DirectoryI
		,
		DivI
	{
		public SeqI dirs => new Seq(this);

		public Directory(nilnul.fs._address.dir.str_.seq.Started dsts) : base(dsts)
		{
		}



		public Directory(IEnumerable<DirI> boxed) : base(boxed)
		{
		}

		public Directory(params DirI[] boxed) : base(boxed)
		{
		}

		public Directory(DirI head, Seq tail) : base(head, tail)
		{
		}

		public Directory(DirI head, SeqI<DirI> boxed) : base(head, boxed)
		{
		}

		public Directory(DirI head, IEnumerable<DirI> boxed) : base(head, boxed)
		{
		}

		public Directory(DirectoryI directory) : base(directory.dirs)
		{
		}

		static public Directory Ov(DocumentI document)
		{
			return new Directory(
				document.div.dirs.Concat(
					new DirI[] {
						new Dir(
							document.doc
						)

					}
				)
			);
		}
		static public Directory Ov(DestinationI destination)
		{
			switch (DestinationA.Document0Directory(destination))
			{
				case DirectoryI directory:
					return new Directory(directory);
				case DocumentI document:
					return Directory.Ov(document);
				default:
					throw new UnexpectedTypeException();
					break;
			}

		}

		public override string ToString()
		{
			return nilnul.txt.accumulate_.Join.Singleton.accumulate(
				this.Select(x => x.ToString())
			);
		}


		public static Directory Parse(string txt)
		{
			nilnul.character_.cha.vow_.fs_.DirSep.Singleton.vow(txt.Last());

			return _address.directory_._DocumentX.Exe(
				_address.Document.Parse(
					txt.Substring(0, txt.Length - 1)
				)
			);

		}
	}
}
