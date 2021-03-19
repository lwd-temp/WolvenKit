using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalConditionData : CVariable
	{
		private CUInt32 _callbackId;
		private CBool _lastValue;

		[Ordinal(0)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetProperty(ref _callbackId);
			set => SetProperty(ref _callbackId, value);
		}

		[Ordinal(1)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get => GetProperty(ref _lastValue);
			set => SetProperty(ref _lastValue, value);
		}

		public AIStackSignalConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
