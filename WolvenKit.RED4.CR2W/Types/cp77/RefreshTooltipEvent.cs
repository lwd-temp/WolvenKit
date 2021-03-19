using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshTooltipEvent : redEvent
	{
		private wCHandle<inkWidget> _widget;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public RefreshTooltipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
