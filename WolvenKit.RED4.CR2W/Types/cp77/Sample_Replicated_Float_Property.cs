using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Float_Property : CVariable
	{
		private CFloat _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CFloat Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}

		public Sample_Replicated_Float_Property(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
