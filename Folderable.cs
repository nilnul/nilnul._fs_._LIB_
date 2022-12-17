using nilnul.fs.address.be_.folderable.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs
{
	public interface FolderableI:address_.FolderableI
	{
		//nilnul.fs.address.be_.folderable.vow.Ee1 addressee { get; }
	}

	public class Folderable
		: nilnul.fs.address_.Folderable //.folderable.vow.Ee1
		
		,
		FolderableI
	{
		public Folderable(AddressI1 val) : base(val)
		{
		}

		public Folderable(string folder):this( nilnul.fs.AddressA1.Parse(folder) )
		{
		}

		//public Ee1 addressee =>this;
	}
}
