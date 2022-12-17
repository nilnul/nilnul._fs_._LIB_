using System.IO;

namespace nilnul.fs.folder.dir.move_
{

	public class _TgtFolderNoSameDenoteX
	{
	

		public static void _assumeTargetParenExist(nilnul.fs.address_.ShieldI sourceParent, string sourceDir, string _targetParent_Exists, StreamWriter log)
		{
			var src = nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(sourceParent, sourceDir);

			nilnul.fs.folder.destinations._MoveX._Void(
				src
				,
				System.IO.Path.Combine(_targetParent_Exists, sourceDir)
				, log
			);
			nilnul.fs.folder._DropX.Vod(src);
		}



		public static void _assumeTargetParenExist(nilnul.fs.Folder sourceParent, string sourceDir, string _targetParent_Exists, StreamWriter log)
		{
			var target = System.IO.Path.Combine(_targetParent_Exists, sourceDir);
			var src = nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(sourceParent.en, sourceDir);
			nilnul.fs.folder.destinations._MoveX._Void(
					src
					,
					target
					, log
				);
			nilnul.fs.folder._DropX.Vod(src);
		}

		public static void _Void(nilnul.fs.Folder sourceParent, string sourceDir, string _targetParent_Exists, StreamWriter log)
		{
			var target = System.IO.Path.Combine(_targetParent_Exists, sourceDir);

			var src = nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(sourceParent.en, sourceDir);

			nilnul.fs.folder.destinations._MoveX._Void(
					src
					,
					target
					, log
				);
			nilnul.fs.folder._DropX.Vod(src);
		}

		public static void _Vod(nilnul.fs.Folder sourceParent, fs._address.DirI sourceDir, nilnul.fs.FolderI _targetParent_Exists)
		{
			var target = new nilnul.fs.address_.shield_.BaseDir(_targetParent_Exists.address.en,sourceDir);


			var src =new nilnul.fs.address_.shield_.BaseDir(sourceParent.en, sourceDir);

			nilnul.fs.folder.destinations._MoveX.Void(
					src
					,
					target
					
				);
			nilnul.fs.folder._DropX.Vod(src);
		}


		public static void _assumeTagetParentNew0Blank(nilnul.fs.Folder sourceParent, string sourceDir, string _targetParent_Exists, StreamWriter log)
		{
			var target = System.IO.Path.Combine(_targetParent_Exists, sourceDir);
			var src = nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(sourceParent.en, sourceDir);

			nilnul.fs.folder.destinations.move_._TargetBlankX._Void(
					src
					,
					target
					, log
				);
			nilnul.fs.folder._DropX.Vod(src);
		}

		public static void _Void(nilnul.fs.address_.ShieldI sourceParent, string sourceDir, string _targetParent_Exists, StreamWriter log)
		{
			var src = nilnul.fs.address_.shield_.BaseDir.Create_ofDirInDst(sourceParent, sourceDir);

			nilnul.fs.folder.destinations._MoveX._Void(
				src,
				System.IO.Path.Combine(_targetParent_Exists, sourceDir)
				, log
			);
			nilnul.fs.folder._DropX.Vod(src);

		}


	}
}
