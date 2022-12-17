using System;
using System.Linq;

namespace nilnul.fs._address.division.co._duct.pass_
{
	[Obsolete()]
	public class SuffixedsDoc :


		nilnul.fs._address.division.co._duct.IPass
	{
		private division.co._duct._pass.step.Suffixeds _relPath;
		public division.co._duct._pass.step.Suffixeds relPath
		{
			get { return _relPath; }
			set { _relPath = value; }
		}

		private nilnul.fs._address.DocI _doc;
		public nilnul.fs._address.DocI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public SuffixedsDoc(division.co._duct._pass.step.Suffixeds relPath, DocI doc)
		{
			_relPath = relPath;
			_doc = doc;
		}

		 public division.co._duct._pass.step.Suffixeds toDeckEnded() {
			return new division.co._duct._pass.step.Suffixeds(

				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					_relPath
					,
					new division.co._duct._pass.step.Suffixed(
						_doc

					)
				)
			);
		}

		static public SuffixedsDoc Parse(string s) {
			var lastIndexPlus = s.LastIndexOfAny(new []{ '\\','/'})+1;


			return new SuffixedsDoc(
				division.co._duct._pass.step.Suffixeds.Parse(s.Substring(0,lastIndexPlus) )
				,
				new nilnul.fs._address.Doc(s.Substring(lastIndexPlus) )
			);
		}
		public override string ToString()
		{
			return $"{_relPath}{_doc}";
		}
	}
}