﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be._vow_
{
	[Obsolete()]
	public class Shield<TShield, TBe>
		:nilnul.obj.be.Vow1<TShield,TBe>
		,
		nilnul.fs.address_.shield._vow_.ShieldI<TShield>

		where TShield: nilnul.fs.address_.ShieldI
		where TBe:nilnul.fs.address_.shield._be_.ShieldI<TShield>,new()
	{

	}
}
