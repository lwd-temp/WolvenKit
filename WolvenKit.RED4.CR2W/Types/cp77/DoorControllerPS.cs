using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorControllerPS : ScriptableDeviceComponentPS
	{
		private DoorSetup _doorProperties;
		private CHandle<EngDemoContainer> _doorSkillChecks;
		private CBool _isOpened;
		private CBool _isLocked;
		private CBool _isSealed;
		private CBool _alarmRaised;
		private CBool _isBusy;
		private CBool _isLiftDoor;
		private CBool _isPlayerAuthorised;
		private CArray<entEntityID> _openingTokens;

		[Ordinal(103)] 
		[RED("doorProperties")] 
		public DoorSetup DoorProperties
		{
			get => GetProperty(ref _doorProperties);
			set => SetProperty(ref _doorProperties, value);
		}

		[Ordinal(104)] 
		[RED("doorSkillChecks")] 
		public CHandle<EngDemoContainer> DoorSkillChecks
		{
			get => GetProperty(ref _doorSkillChecks);
			set => SetProperty(ref _doorSkillChecks, value);
		}

		[Ordinal(105)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetProperty(ref _isOpened);
			set => SetProperty(ref _isOpened, value);
		}

		[Ordinal(106)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(107)] 
		[RED("isSealed")] 
		public CBool IsSealed
		{
			get => GetProperty(ref _isSealed);
			set => SetProperty(ref _isSealed, value);
		}

		[Ordinal(108)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get => GetProperty(ref _alarmRaised);
			set => SetProperty(ref _alarmRaised, value);
		}

		[Ordinal(109)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get => GetProperty(ref _isBusy);
			set => SetProperty(ref _isBusy, value);
		}

		[Ordinal(110)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetProperty(ref _isLiftDoor);
			set => SetProperty(ref _isLiftDoor, value);
		}

		[Ordinal(111)] 
		[RED("isPlayerAuthorised")] 
		public CBool IsPlayerAuthorised
		{
			get => GetProperty(ref _isPlayerAuthorised);
			set => SetProperty(ref _isPlayerAuthorised, value);
		}

		[Ordinal(112)] 
		[RED("openingTokens")] 
		public CArray<entEntityID> OpeningTokens
		{
			get => GetProperty(ref _openingTokens);
			set => SetProperty(ref _openingTokens, value);
		}

		public DoorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
