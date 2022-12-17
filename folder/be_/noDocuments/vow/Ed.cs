using System;

namespace nilnul.fs.folder.be_.noDocuments.vow
{
#pragma warning disable CS0612 // 'Ed<Folder, Vow>' is obsolete
	public class Ed : nilnul.obj.vow.Ed<nilnul.fs.Folder, Vow>
#pragma warning restore CS0612 // 'Ed<Folder, Vow>' is obsolete
	{
		public Ed(Folder val) : base(val)
		{

		}
		public Ed(string name) : this(Folder.FroAddress(name))
		{

		}

		[Obsolete(nameof(drop))]
		public void del()
		{
			System.IO.Directory.Delete(this.ToString(), true);
		}


		//drop the folder(including all divs)
		public void drop()
		{
			System.IO.Directory.Delete(this.ToString(), true);
		}

	}
}
