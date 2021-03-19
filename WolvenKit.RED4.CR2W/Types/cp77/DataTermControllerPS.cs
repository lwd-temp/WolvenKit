using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private CEnum<EFastTravelTriggerType> _triggerType;

		[Ordinal(103)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetProperty(ref _linkedFastTravelPoint);
			set => SetProperty(ref _linkedFastTravelPoint, value);
		}

		[Ordinal(104)] 
		[RED("triggerType")] 
		public CEnum<EFastTravelTriggerType> TriggerType
		{
			get => GetProperty(ref _triggerType);
			set => SetProperty(ref _triggerType, value);
		}

		public DataTermControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
