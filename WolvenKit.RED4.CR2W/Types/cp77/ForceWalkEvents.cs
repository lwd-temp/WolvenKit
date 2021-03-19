using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceWalkEvents : LocomotionGroundEvents
	{
		private CFloat _storedSpeedValue;

		[Ordinal(0)] 
		[RED("storedSpeedValue")] 
		public CFloat StoredSpeedValue
		{
			get => GetProperty(ref _storedSpeedValue);
			set => SetProperty(ref _storedSpeedValue, value);
		}

		public ForceWalkEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
