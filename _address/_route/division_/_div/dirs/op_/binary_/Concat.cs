using nilnul.fs._address.dir.str_;
using System;
using System.Linq;

namespace nilnul.fs._address.dirs.op_.binary_
{
	public class Concat : CoI
	{
#pragma warning disable CS0612 // 'DirsI' is obsolete
#pragma warning disable CS0612 // 'DirsI' is obsolete
#pragma warning disable CS0612 // 'DirsI' is obsolete
		public DirsI op(DirsI arg, DirsI arg1)
#pragma warning restore CS0612 // 'DirsI' is obsolete
#pragma warning restore CS0612 // 'DirsI' is obsolete
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{
#pragma warning disable CS0612 // 'Dirs' is obsolete
			return new Dirs(arg.Concat(arg1));
#pragma warning restore CS0612 // 'Dirs' is obsolete
			throw new NotImplementedException();
		}

#pragma warning disable CS0612 // 'DirsI' is obsolete
#pragma warning disable CS0612 // 'DirsI' is obsolete
		public DirsI op(DirsI arg, DirI arg1)
#pragma warning restore CS0612 // 'DirsI' is obsolete
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{
#pragma warning disable CS0612 // 'Dirs' is obsolete
			return new Dirs(arg.Concat(new[] { arg1 }));
#pragma warning restore CS0612 // 'Dirs' is obsolete
			throw new NotImplementedException();
		}


		static public Concat Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Concat>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Concat>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Concat>' is obsolete: 'Singleton'
			}
		}


#pragma warning disable CS0612 // 'DirsI' is obsolete
		public DirsI op(
#pragma warning restore CS0612 // 'DirsI' is obsolete
#pragma warning disable CS0612 // 'DirsI' is obsolete
			DirsI dirs, Dir doc
#pragma warning restore CS0612 // 'DirsI' is obsolete
		)
		{
#pragma warning disable CS0612 // 'Dirs' is obsolete
			return new Dirs(
#pragma warning restore CS0612 // 'Dirs' is obsolete
				nilnul.obj.seq.convert_._AppendX.Append(dirs,
				  doc)
			);
			throw new NotImplementedException();
		}

#pragma warning disable CS0612 // 'DirsI' is obsolete
		public DirsI op(SeqI dirs, Dir dir)
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{
#pragma warning disable CS0612 // 'Dirs' is obsolete
			return new Dirs(
#pragma warning restore CS0612 // 'Dirs' is obsolete
				nilnul.obj.seq.convert_._AppendX.Append(dirs,
				  dir)
			);

		}
	}
}
