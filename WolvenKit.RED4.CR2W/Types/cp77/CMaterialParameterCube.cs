using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterCube : CMaterialParameter
	{
		private rRef<ITexture> _texture;

		[Ordinal(2)] 
		[RED("texture")] 
		public rRef<ITexture> Texture
		{
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}

		public CMaterialParameterCube(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
