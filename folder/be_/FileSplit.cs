using nilnul.fs.address_.shield_.based_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// this is a folder gerenerated by <see cref="nilnul.fs.file.split_._ThinToeX"/>
	/// </summary>
	public class FileSplit
		:
		nilnul.fs.folder.BeI1
	{
		public bool be(FolderI1 obj)
		{
			/// we might still have some configuration files/folders. these files/folders have special name that should be ignored.
			///

			if (nilnul.fs.folder.dirs_._ConsideredX.Dirs(obj).Any()) {
				return false;
			}

			var docs = nilnul.fs.folder.docs_._ConsideredX.Docs(obj);

			if (!docs.Any())
			{
				return false;
			}

			var vered = docs.Select(d=> nilnul.txt_.Vered3.Parse(d.caption.en));

			//if (!nilnul.txt_.vered.str_.started.be_.SameNom.Be(
			//		docs.Select(d=>d.caption.en)
			//	)
			//)
			//{
			//	return false;
			//}

			if (vered.Any(x=>x.nom.ee != fs.file.split_._ThinToeX.NOM))
			{
				return false;
			}

			var vers = vered.Select(x=>x.ver.main.en).OrderBy( b=>b);

			if (
				nilnul.num.str.be_.InitialOfNumSeq.Singleton.be(
					vers
				)
			)
			{

				return true;

			}
			return false;




			
		}

		public bool be(nilnul.fs.address_.ShieldI1 d)
		{
			return nilnul.fs.folder.be._ExtensionsX.Be(
				this,d

			);
		}

		static public FileSplit Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<FileSplit>.Instance;
			}
		}

	}
}
