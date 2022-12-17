using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_.vered_.newest
{
	/// <summary>
	/// if newest is null,
	///		create a dir
	///	if newest is not dir
	///		create a new dir
	///	if newest is not emtpy
	///		create a newer dir.
	/// </summary>
	static public class _EnsureEmptyX
	{

		public static nilnul.fs.Folder1 Folder(
			nilnul.fs.FolderI1 container
			,
			nilnul.txt_._vered.Name denote
		)
		{

			var newest = nilnul.fs.folder.dst_.vered_._NewestX.Dst0nul(
				container
				,
				denote
			);

			if (
			newest is null

			)
			{
				return nilnul.fs.folder._CreateX.Folder(
					 address_.shield_.based_.Child.Create_dirDenote(
						container.address.ee
						,
						denote
					)
				);
			}

			if (newest is _address._route.division_._div.DirI dst)
			{

				var newestShield1 = new nilnul.fs.address_.shield_.based_.Child(
					container.address.ee
					,
					dst
				);


				if (

					nilnul.fs.folder.be_.Empty1.Singleton.be(
						 newestShield1
					)
				)
				{
					return new nilnul.fs.Folder1(newestShield1);
				}


				return nilnul.fs.folder._CreateX.Folder(
					 address_.shield_.based_.Child.Create_dirDenote(
						container.address.ee
						,
						nilnul.txt_.vered.op_.unary_._NextX.Next(newest.caption)
					)
				);
				
			}

			///newest is a doc
			return nilnul.fs.folder._CreateX.Folder(
					 address_.shield_.based_.Child.Create_dirDenote(
						container.address.ee
						,
						nilnul.txt_.vered.op_.unary_._NextX.Next(newest.caption)
					)
			);

		}


		public static nilnul.fs.Folder1 Folder(nilnul.fs.FolderI1 container, string vered)
		{
			return Folder(
				container
				,
				new nilnul.txt_._vered.Name(vered)
			);
		}
		public static fs.Folder1 Folder(ShieldI1 parent, string v)
		{
			return  Folder(
				new Folder1(parent)
				,
				v
			);

		}

		public static nilnul.fs.Folder Folder(
			nilnul.fs.FolderI container
			,
			nilnul.fs._address._dst.denote_.Vered denote
		)
		{

			txt_.Vered newest = nilnul.fs.folder.denote_.vered_._NewestX.VeredOrNul(
				container
				,
				denote.germ
			);

			if (newest == null
				||
				 newest.version.toBigint() < denote.version.toBigint()
			)
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
		public static nilnul.fs.Folder Folder(nilnul.fs.FolderI container, string vered)
		{
			return Folder(
				container
				,
				nilnul.fs._address._dst.denote_.Vered.Parse(vered)
			);
		}

	}
}
