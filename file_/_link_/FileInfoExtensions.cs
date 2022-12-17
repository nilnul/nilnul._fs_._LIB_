using nilnul.fs.location_.link_._sym_;
using System;
using System.IO;

namespace nilnul.fs.file._link_
{
	/// <summary>
	/// Extension methods for System.IO.FileInfo to provide symbolic link support.
	/// </summary>
	public static class FileInfoExtensions
	{
		/// <summary>
		/// Creates a symbolic link to this file at the specified path.
		/// </summary>
		/// <param name="it">the source file for the symbolic link.</param>
		/// <param name="path">the path of the symbolic link.</param>
		public static void CreateSymbolicLink(this FileInfo it, string path)
		{
#pragma warning disable CS0612 // 'SymbolicLink' is obsolete
#pragma warning disable CS0618 // 'SymbolicLink.CreateFileLink(string, string)' is obsolete: 'poosible exception'
			SymbolicLink.CreateFileLink(path, it.FullName);
#pragma warning restore CS0618 // 'SymbolicLink.CreateFileLink(string, string)' is obsolete: 'poosible exception'
#pragma warning restore CS0612 // 'SymbolicLink' is obsolete
		}

		/// <summary>
		/// Determines whether this file is a symbolic link.
		/// </summary>
		/// <param name="it">the file in question.</param>
		/// <returns><code>true</code> if the file is, indeed, a symbolic link, <code>false</code> otherwise.</returns>
		public static bool IsSymbolicLink(this FileInfo it)
		{
#pragma warning disable CS0612 // 'SymbolicLink' is obsolete
			return SymbolicLink.GetTarget(it.FullName) != null;
#pragma warning restore CS0612 // 'SymbolicLink' is obsolete
		}

		/// <summary>
		/// Determines whether the target of this symbolic link still exists.
		/// </summary>
		/// <param name="it">The symbolic link in question.</param>
		/// <returns><code>true</code> if this symbolic link is valid, <code>false</code> otherwise.</returns>
		/// <exception cref="System.ArgumentException">If the file in question is not a symbolic link.</exception>
		public static bool IsSymbolicLinkValid(this FileInfo it)
		{
			return System.IO.File.Exists(it.GetSymbolicLinkTarget());
		}

		/// <summary>
		/// Returns the full path to the target of this symbolic link.
		/// </summary>
		/// <param name="it">The symbolic link in question.</param>
		/// <returns>The path to the target of the symbolic link.</returns>
		/// <exception cref="System.ArgumentException">If the file in question is not a symbolic link.</exception>
		public static string GetSymbolicLinkTarget(this FileInfo it)
		{
			if (!it.IsSymbolicLink())
				throw new ArgumentException("file specified is not a symbolic link.");
#pragma warning disable CS0612 // 'SymbolicLink' is obsolete
			return SymbolicLink.GetTarget(it.FullName);
#pragma warning restore CS0612 // 'SymbolicLink' is obsolete
		}
	}
}