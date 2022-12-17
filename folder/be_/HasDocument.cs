using System.Linq;

namespace nilnul.fs.folder.be_
{
	public class HasDocument
		: nilnul.fs.folder.BeA
	{
		public override bool be(nilnul.fs.FolderI obj)
		{
			return
				nilnul.fs.folder._DocumentsX.Documents(obj).Any();
			;
			//throw new NotImplementedException();
		}

		static public HasDocument Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<HasDocument>.Instance;
			}
		}



	}
}
