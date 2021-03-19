using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemUnpackedView : ISerializable
	{
		private CName _name;
		private CHandle<inkWidgetLibraryItemInstance> _instance;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("instance")] 
		public CHandle<inkWidgetLibraryItemInstance> Instance
		{
			get => GetProperty(ref _instance);
			set => SetProperty(ref _instance, value);
		}

		public inkWidgetLibraryItemUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
