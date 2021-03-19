using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckDeviceHackIcon : inkWidgetLogicController
	{
		private inkImageWidgetReference _image;

		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		public CyberdeckDeviceHackIcon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
