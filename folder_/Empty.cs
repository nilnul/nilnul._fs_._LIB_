using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	public class Empty : nilnul.fs.folder.be_.empty.vow.Ee
		,
		nilnul.fs.FolderI
	{
		public Exist address => (ee.address);

		public Empty(FolderI val) : base(val)
		{
		}

		public Empty(ShieldI val) : base(val)
		{
		}

		static public Empty OvShield(string s) {
			return new Empty(nilnul.fs.address_.Shield._Parse_ofTrimmed(s));
		}

		static public Empty OvAddress(string s) {
			return OvShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(s)
			);
		}
	}
}
