using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.cfg_._nn
{
	/*
	 <dnt_>
			<unlist>
				abc
				def
			</unlist>
	</dnt>

	it might be symlinked by dir in other folder where the cfg doesnot unlist it. So the "neglect" setting inside the folder is important.
	 */
	public interface IChild
	{
	}
}
