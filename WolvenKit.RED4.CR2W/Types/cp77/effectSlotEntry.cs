using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectSlotEntry : CVariable
	{
		private CName _slotName;
		private Vector3 _relativePosition;
		private Quaternion _relativeRotation;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get => GetProperty(ref _relativePosition);
			set => SetProperty(ref _relativePosition, value);
		}

		[Ordinal(2)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get => GetProperty(ref _relativeRotation);
			set => SetProperty(ref _relativeRotation, value);
		}

		public effectSlotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
