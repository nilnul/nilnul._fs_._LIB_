using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.fs.location_._folder.address.be_
{
	[Obsolete()]
	public class Exist
		:
		/*obj::*/nilnul.obj.BeI1<nilnul.fs.address_.FolderI>
	{
		public bool be(address_.Folder obj)
		{
			return System.IO.Directory.Exists(
				obj.ToString()	
			);
			//throw new NotImplementedException();
		}

		public class En
			:
			nilnul.obj.be.En_beDefaultable<nilnul.fs.address_.Folder, Exist>
		{
			public En(address_.Folder val) : base(val)
			{

			}
		}
	}
}
