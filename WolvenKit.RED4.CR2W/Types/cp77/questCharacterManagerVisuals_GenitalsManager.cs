using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_GenitalsManager : questICharacterManagerVisuals_NodeSubType
	{
		private CName _bodyGroupName;
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("bodyGroupName")] 
		public CName BodyGroupName
		{
			get => GetProperty(ref _bodyGroupName);
			set => SetProperty(ref _bodyGroupName, value);
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questCharacterManagerVisuals_GenitalsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
