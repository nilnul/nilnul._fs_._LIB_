namespace nilnul.fs.folder.dsts_
{
	/// <summary>
	/// per <see cref="folder.cfg_.INilnul0"/>, there are some dsts that are unlisted
	/// </summary>
	/// vs:
	///		<see cref="dnts_.IUnlisted"/>
	///			which wouldnot allow trailing slash while this allows a trailing slash to denote a dir not a doc.
	///			for a dst with no trailing slash
	///				it can denote a doc
	///					or a dir
	///						as dir is considered longer thus sub/lower in level to dnt
	/// 
	public interface IUnlisted {

	}
}
