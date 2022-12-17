using nilnul.fs.address_;
using nilnul.fs.file.be_.nonlink.vow;
using nilnul.fs.folder.be_.normal.vow;

namespace nilnul.fs.file_
{
	public interface NonlinkI
	{
		nilnul.fs.file.be_.nonlink.vow.Ee nonlink { get; }
	}
	/// <summary>
	/// nonlink
	/// </summary>
	public class Nonlink
		: nilnul.fs.file.be_.nonlink.vow.Ee
		,
		NonlinkI
	{
		public Nonlink(FileI val) : base(val)
		{

		}
		public Nonlink(SpearI shield) : base(shield)
		{

		}
		

		 public Nonlink(string shield):base(
			 shield
		)
		{
			
		}

		public Ee nonlink => this;
	}
}
