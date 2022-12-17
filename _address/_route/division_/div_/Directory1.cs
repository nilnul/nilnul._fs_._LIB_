using nilnul.fs._address.dir.str_;
using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using D = nilnul.fs._address._route.division_._div.DirI;

namespace nilnul.fs._address._route.division_.div_
{
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	///
	public class Directory
		:
		nilnul.fs._address._route.division_._div.dir.str_.Started
		,
		DirectoryI
		,
		DivI
	{
		//public SeqI dirs => new Seq(this);

		public Directory(nilnul.fs._address._route.division_._div.dir.str_.Started dsts) : base(dsts)
		{
		}



		public Directory(IEnumerable<D> boxed) : base(boxed)
		{
		}

		public Directory(params D[] boxed) : base(boxed)
		{
		}

		public Directory(D head , _div. dir.StrI2 tail) : base(head, tail)
		{
		}

		public Directory(D head, SeqI<D> boxed) : base(head, boxed)
		{
		}

		public Directory(D head, IEnumerable<D> boxed) : base(head, boxed)
		{
		}

		public Directory(DirectoryI directory) : base(directory)
		{
		}

		static public Directory Of(division_.div.DntedI document)
		{
			return new Directory(
				document.div.Concat(
					new _div. Dir[] {
						new _div.Dir(
							document.dnt
						)

					}
				)
			);
		}
		static public Directory Of(DestinationI destination)
		{
			switch (DestinationA.Denotation0directory(destination))
			{
				case DirectoryI directory:
					return new Directory(directory);
				case div.DntedI document:
					return Directory.Of(document);
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

			return _address._route.division_.div_.directory.op_.of_._DocumentX.Exe(
				_address._route.division_.div.Dnted.Parse(
					txt.Substring(0, txt.Length - 1)
				)
			);

		}
	}
}
