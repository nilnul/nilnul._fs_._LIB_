using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.volRoute_;
using System.IO;

namespace nilnul.fs.file_
{
	public class VolRoute
		: nilnul.fs.address_.volRoute_.element.be_.exist.vow.Ee
	{
		public VolRoute(Element val) : base(val)
		{

		}

		public nilnul.fs._address.route_.deckedDocument_.OfDocument route {
			get {
				return 
					ed.deckedDocument
				;
			}
		}

		static public implicit operator FileInfo(VolRoute volRoute)
		{
			return new FileInfo(volRoute.ToString());
		}
		static public explicit operator VolRoute(FileInfo fileInfo)
		{
			return new VolRoute(
				fileInfo
			);
		}
	}
}
