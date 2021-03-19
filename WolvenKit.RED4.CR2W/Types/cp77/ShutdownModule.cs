using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShutdownModule : redEvent
	{
		private CInt32 _module;

		[Ordinal(0)] 
		[RED("module")] 
		public CInt32 Module
		{
			get => GetProperty(ref _module);
			set => SetProperty(ref _module, value);
		}

		public ShutdownModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
