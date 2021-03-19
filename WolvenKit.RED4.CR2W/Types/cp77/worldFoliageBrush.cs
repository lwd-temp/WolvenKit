using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrush : CResource
	{
		private CArray<CHandle<worldFoliageBrushItem>> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<CHandle<worldFoliageBrushItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public worldFoliageBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
