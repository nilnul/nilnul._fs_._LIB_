namespace nilnul.fs._address.document.map_.spearNul
{
	/// <summary>
	/// get the map_.spearNul, and a target folder, copy the files by link to the target; if the val is nul, a directory is created
	/// </summary>
	static public class _MaterializeBySymbolX
	{
		static public void Vod(SpearNul map, nilnul.fs.FolderI target)
		{
			foreach (var item in map)
			{
				if (item.Value == null)
				{
					nilnul.fs.folder._EnsureX.Void(
						new nilnul.fs.address_.shield_.BaseDiv(
							target.address.en
							,
							item.Key
						)
					);
				}
				else
				{
					nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(
						new nilnul.fs.address_.spear_.ParentDocument(
							target.address.en, item.Key
						)
						,
						item.Value
					);
				}
			}
		}
	}
}
