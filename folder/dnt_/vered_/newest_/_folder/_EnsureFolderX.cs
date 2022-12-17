using System;

namespace nilnul.fs.folder.dnt_.vered_.newest_._folder
{
	public static class _EnsureNewestBeFolderX
	{
	
		public static nilnul.fs.Folder1 Folder(nilnul.fs.FolderI1 container, nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom denote)
		{
			var newest = nilnul.fs.folder.dnt_.vered_._NewestX.VeredOrNul(container, denote);

			if (newest is null)
			{
				return nilnul.fs.folder._CreateX.Folder(
					 address_.shield_.based_.Child.Create_dirDenote(
						container.address.ee
						,
						denote
					)
				);
				;

			}

			address_.shield_.based_.Child newestShield = nilnul.fs.address_.shield_.based_.Child .Create_dirDenote(
				container.address.ee
				,
				newest
			);
			if (

				nilnul.fs.address_.shield.be_.Folder.Singleton.be(
					 newestShield
				)
			)
			{
				return new nilnul.fs.Folder1(newestShield);
			}

			return nilnul.fs.folder._CreateX.Folder(
				 address_.shield_.based_.Child.Create_dirDenote(
					container.address.ee
					,
					nilnul.txt_.vered.op_.unary_._NextX.Next(newest)
				)
			);
			;


		}

		public static nilnul.fs.Folder1 Folder_ofNom(nilnul.fs.FolderI1 container, string vered)
		{
			return Folder(container, new nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom(vered));
		}



		public static nilnul.fs.Folder Folder(nilnul.fs.FolderI container, nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom denote)
		{
			var newest = nilnul.fs.folder.dnt_.vered_._NewestX.VeredOrNul(container, denote);

			if (newest is null)
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

		[Obsolete(nameof(Folder))]
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

		public static nilnul.fs.Folder Folder_ofNom(nilnul.fs.FolderI container, string vered)
		{
			return Folder(container, nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom.CreateByAppendingSubIfNeed(vered));
		}


		[Obsolete(nameof(Folder_ofNom))]
		public static nilnul.fs.Folder Folder_ofKey(nilnul.fs.FolderI container, string vered)
		{
			return Folder_ofNom(container, vered);
		}


		public static nilnul.fs.Folder1 Folder_ofNom(nilnul.fs.address_.ShieldI1 container, string vered)
		{
			return Folder_ofNom(
				new nilnul.fs.Folder1(
					container
				), (vered));
		}

		public static nilnul.fs.Folder Folder_ofNom(nilnul.fs.address_.ShieldI container, string vered)
		{
			return Folder_ofNom(
				new nilnul.fs.Folder(
					container
				), nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom.CreateByAppendingSubIfNeed(vered));
		}

		public static nilnul.fs.Folder Folder_ofFolderable_ofNom(nilnul.fs.address_.ShieldI container, string vered)
		{
			return Folder_ofNom(
				 nilnul.fs.folder._EnsureX.Folder(
					container
				), nilnul.fs._address._route.division_._div._dir.dnt_._vered.Nom.CreateByAppendingSubIfNeed(vered));
		}




	}
}
