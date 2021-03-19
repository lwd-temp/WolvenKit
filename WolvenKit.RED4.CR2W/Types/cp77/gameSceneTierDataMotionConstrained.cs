using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		private NodeRef _splineRef;
		private CFloat _adjustingSpeed;
		private CFloat _adjustingDuration;
		private CFloat _travellingSpeed;
		private CFloat _travellingDuration;
		private CInt32 _notificationBackwardIndex;

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(3)] 
		[RED("adjustingSpeed")] 
		public CFloat AdjustingSpeed
		{
			get => GetProperty(ref _adjustingSpeed);
			set => SetProperty(ref _adjustingSpeed, value);
		}

		[Ordinal(4)] 
		[RED("adjustingDuration")] 
		public CFloat AdjustingDuration
		{
			get => GetProperty(ref _adjustingDuration);
			set => SetProperty(ref _adjustingDuration, value);
		}

		[Ordinal(5)] 
		[RED("travellingSpeed")] 
		public CFloat TravellingSpeed
		{
			get => GetProperty(ref _travellingSpeed);
			set => SetProperty(ref _travellingSpeed, value);
		}

		[Ordinal(6)] 
		[RED("travellingDuration")] 
		public CFloat TravellingDuration
		{
			get => GetProperty(ref _travellingDuration);
			set => SetProperty(ref _travellingDuration, value);
		}

		[Ordinal(7)] 
		[RED("notificationBackwardIndex")] 
		public CInt32 NotificationBackwardIndex
		{
			get => GetProperty(ref _notificationBackwardIndex);
			set => SetProperty(ref _notificationBackwardIndex, value);
		}

		public gameSceneTierDataMotionConstrained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
