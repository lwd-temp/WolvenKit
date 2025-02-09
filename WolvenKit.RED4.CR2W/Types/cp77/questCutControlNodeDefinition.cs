using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCutControlNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _permanent;

		[Ordinal(2)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetProperty(ref _permanent);
			set => SetProperty(ref _permanent, value);
		}

		public questCutControlNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
