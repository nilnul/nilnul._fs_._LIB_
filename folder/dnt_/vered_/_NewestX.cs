using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.txt_._vered;
using System;

namespace nilnul.fs.folder.dnt_.vered_
{
	public class _NewestX
	{
		static public nilnul.txt_.Vered2 VeredOrNul(
			nilnul.fs.FolderI container
			,
			nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom denoteGerm
		)
		{
			return nilnul.txt_.vereds.NewestOrDefaultX.Vered(
				new nilnul.fs.folder.dnt_.Vereds(container).seq(denoteGerm)
			);
		}

		public static nilnul.txt_.Vered2 VeredOrNul_ofNom(nilnul.fs.FolderI1 parent, string v)
		{
			return nilnul.txt_.vereds.NewestOrDefaultX.Vered(
				new nilnul.fs.folder.dnt_.Vereds1(parent).seq_ofNom(v)
			);


		}

		public static txt_.Vered3 VeredOrNul(FolderI1 container, Name denote)
		{
			return nilnul.txt_.vered_.nomed.str.NewestOrDefaultX.Vered(
				new nilnul.fs.folder.dnt_.Vereds1(container).seq1(denote)
			);
		}

		

		public static nilnul.txt_.Vered2 VeredOrNul_ofNom(ShieldI1 parent, string v)
		{

			return VeredOrNul_ofNom(
				new nilnul.fs.Folder1(parent),v
			);

		}

		static public nilnul.txt_.Vered1 VeredOrNul(
			nilnul.fs.FolderI container
			,
			nilnul.fs._address._dst.denote_._vered.Germ denoteGerm
		)
		{
			return nilnul.txt_.vered.set.NewestOrDefaultX.Vered(

				new nilnul.fs.folder.denote_.Vereds(container).seq(denoteGerm)
			);
		}

		internal static txt_.Vered2 VeredOrNul(FolderI parent, DocI doc)
		{
			var vered = nilnul.txt_.Vered2.Parse(doc.ToString());

			return
				nilnul.txt_.vereds.NewestOrDefaultX.Vered(
					new nilnul.fs.folder.dnt_.Vereds(parent).seq(vered)
				)
			;

		}
		internal static txt_.Vered2 VeredOrNul(ShieldI parent, DocI doc)
		{
			return VeredOrNul(
				new nilnul.fs.Folder(parent)
				,
				doc
			);
		}

	}
}
