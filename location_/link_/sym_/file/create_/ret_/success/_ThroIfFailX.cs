using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.location_.link_.sym_.file.create_.ret_.success
{




	/// <summary>
	/// </summary>



	static public class _ThrowIfFailX
	{
		/// <summary>
		/// the parent of link must be already created
		/// </summary>
		/// <param name="link"></param>
		/// <param name="target">cannot be relative</param>
		static public void _Void_srcParentExist(
			string link
			,
			string target
		)
		{


			//note : CreateSymbolicLinkW is not working.
			if (!_CreateX.Succeed(link, target))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}

		}



		/// <summary>
		/// unicode version with non-priviliged access
		/// </summary>
		/// <param name="link"></param>
		/// <param name="target"></param>
		static public void Void(
			nilnul.fs.address_.spear_.ParentDoc link
			,
			string target
		)
		{
			//var srcTxt = src.shield.ToString();
			System.IO.Directory.CreateDirectory(link.parent.ToString());
			_Void_srcParentExist(link.ToString(), target);

		}

		[Obsolete("",true)]
		static public void Void_target2BeRelative(
			nilnul.fs.FileI targetOfLink
			,
			nilnul.fs.FolderI linkParent
			,
			nilnul.fs._address.DocI linkDoc
		)
		{
			//var srcTxt = src.shield.ToString();

			//System.IO.Directory.CreateDirectory(link.parent.ToString());

			var link = new nilnul.fs.address_.spear_.ParentDoc( 
				linkParent.address.en, 
				linkDoc
			);

			var link2target = nilnul.fs.address_.spear.co._RelPathX.Nulable(
				link,
				targetOfLink.file.en
			);


			_Void_srcParentExist(link.ToString(), link2target.ToString());

		}


		static public void Void(
			nilnul.fs.FileI targetOfLink
			,
			nilnul.fs.FolderI linkParent
			,
			nilnul.fs._address.DocI linkDoc
		)
		{
			//var srcTxt = src.shield.ToString();

			//System.IO.Directory.CreateDirectory(link.parent.ToString());

			var link = new nilnul.fs.address_.spear_.ParentDoc( 
				linkParent.address.en, 
				linkDoc
			);

			


			_Void_srcParentExist(link.ToString(), targetOfLink.ToString());

		}


		[Obsolete("",true)]

		static public void Void_target2BeRelative_linkDocSame(
			nilnul.fs.FileI targetOfLink
			,
			nilnul.fs.FolderI linkParent
		)
		{
			Void_target2BeRelative(
				targetOfLink
				, 
				linkParent
				,
				nilnul.fs.file._DocX.Doc(
					targetOfLink
				)
			);
			

		}

		static public void Void_docSame(
			nilnul.fs.FileI targetOfLink
			,
			nilnul.fs.FolderI linkParent
		)
		{
			Void(
				targetOfLink
				, 
				linkParent
				,
				nilnul.fs.file._DocX.Doc(
					targetOfLink
				)
			);
			

		}

		[Obsolete("",true)]
		static public void Void_target2BeRelative_linkDocSame__ofParentExistAddress(
			string targetOfLink
			,
			string linkParent
		)
		{
			Void_target2BeRelative_linkDocSame(
				new nilnul.fs.File(targetOfLink)
				,
				nilnul.fs.Folder.FroAddress(linkParent)

			);
			

		}

		static public void Void_docSame__ofLinkParentAddressExisted(
			string targetOfLink
			,
			string linkParent
		)
		{
			Void_docSame(
				new nilnul.fs.File(targetOfLink)
				,
				nilnul.fs.Folder.FroAddress(linkParent)

			);
			

		}


		static public void Void(
			nilnul.fs.address_.spear_.ParentDoc src
			,
			SpearI target
		)
		{
			Void(src, target.ToString());

		}

		public static void Void(SpearI parentDocument, SpearI value)
		{
			Void(
				new ParentDoc(parentDocument), value
			);
		}





		/// <summary>
		/// unicode version with non-priviliged access
		/// </summary>
		/// <param name="src"></param>
		/// <param name="target"></param>
		static public void Void(
			string src
			,
			string target
		)
		{
			Void(
				nilnul.fs.address_.spear_.ParentDoc.Parse(src)
				,
				target
			);



		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="target"></param>
		/// <param name="symbolicLink"></param>
		/// <exception cref="">
		/// visual studio has to be run as admin to make this work.
		/// </exception>
		/// 
		[Obsolete("use " + nameof(Void) + " for unicode/nonprivileged access")]
		static public void Exe(
			string src
			,
			string target
		)
		{
			if (!_SymX.CreateSymbolicLink(src, target, _sym.FileOrFolder.File))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}

		}


		[Obsolete("use " + nameof(Void) + " for unicode/nonprivileged access")]
		static public void ExeW(
			string src
			,
			string target
		)
		{
			if (!_SymX.CreateSymbolicLinkW(src, target, _sym.FileOrFolder.File))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}

		}


	}
}
