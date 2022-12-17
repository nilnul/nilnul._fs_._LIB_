using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	public class Newable0empty : nilnul.fs.folder.be_.empty.vow.Ee
		,
		nilnul.fs.FolderI
	{
		public Exist address => (ee.address);

		public Newable0empty(FolderI val) : base(val)
		{
		}

		public Newable0empty(ShieldI val) : base(val)
		{
		}

		static public Newable0empty OvShield(string s) {
			return new Newable0empty(nilnul.fs.address_.Shield._Parse_ofTrimmed(s));
		}

		static public Newable0empty OvAddress(string s) {
			return OvShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(s)
			);
		}
	}
}
