using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StillageControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isCleared;

		[Ordinal(103)] 
		[RED("isCleared")] 
		public CBool IsCleared
		{
			get => GetProperty(ref _isCleared);
			set => SetProperty(ref _isCleared, value);
		}

		public StillageControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
