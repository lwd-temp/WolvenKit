using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInt32ArgumentInstancePS : AIArgumentInstancePS
	{
		private CInt32 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public AIInt32ArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
