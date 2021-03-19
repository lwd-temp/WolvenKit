using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_LocalPosition : gameTransformAnimation_Position
	{
		private Vector3 _position;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		public gameTransformAnimation_Position_LocalPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
