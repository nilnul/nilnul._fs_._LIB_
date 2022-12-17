using System;

namespace nilnul.fs.folder.denote_.vered_.newest_._folder
{
	[Obsolete(nameof(dnt_.vered_.newest_._folder._EnsureNewestBeFolderX))]
	public static class _EnsureNewestBeFolderX
	{
		public static nilnul.fs.Folder Folder(nilnul.fs.FolderI container, nilnul.fs._address._dst.denote_._vered_.Germ denote)
		{
			txt_.Vered newest = nilnul.fs.folder.denote_.vered_._NewestX.VeredOrNul(container, denote);

			if (newest == null)
			{
				return nilnul.fs.folder._CreateX.Folder(
					 address_.shield_.BaseDir.Create_dirDenote(
						container.address.en
						,
						denote
					)
				);
				;

			}

			address_.shield_.BaseDir newestShield = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(
				container.address.en
				,
				newest
			);
			if (

				nilnul.fs.address_.shield.be_.Folder.Singleton.be(
					 newestShield
				)
			)
			{
				return new nilnul.fs.Folder(newestShield);
			}

			return nilnul.fs.folder._CreateX.Folder(
				 address_.shield_.BaseDir.Create_dirDenote(
					container.address.en
					,
					nilnul.txt_.vered.op_.unary_._NextX.Next(newest)
				)
			);
			;


		}

		public static nilnul.fs.Folder Folder_ofKey(nilnul.fs.FolderI container, nilnul.fs._address._dst.denote_.Vered vered)
		{



			return Folder(container, vered.germ);
		}
		public static nilnul.fs.Folder Folder_ofKey(nilnul.fs.FolderI container, string vered)
		{
			return Folder_ofKey(container, nilnul.fs._address._dst.denote_._vered.Germ.CreateByAppendingSubIfNeed(vered));
		}

	}
}
