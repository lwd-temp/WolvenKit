using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ObjectTag : worldEditorDebugColoringSettings
	{
		private CEnum<worldObjectTag> _tag;
		private CColor _color;

		[Ordinal(0)] 
		[RED("tag")] 
		public CEnum<worldObjectTag> Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		public worldDebugColoring_ObjectTag(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
