using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinotaurMechComponent : gameScriptableComponent
	{
		private TweakDBID _deathAttackRecordID;
		private wCHandle<NPCPuppet> _owner;
		private CHandle<MinotaurOnStatusEffectAppliedListener> _statusEffectListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entSimpleColliderComponent> _npcDeathCollisionComponent;
		private CEnum<MechanicalScanType> _currentScanType;
		private CName _currentScanAnimation;

		[Ordinal(5)] 
		[RED("deathAttackRecordID")] 
		public TweakDBID DeathAttackRecordID
		{
			get => GetProperty(ref _deathAttackRecordID);
			set => SetProperty(ref _deathAttackRecordID, value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(7)] 
		[RED("statusEffectListener")] 
		public CHandle<MinotaurOnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(8)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(9)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetProperty(ref _npcDeathCollisionComponent);
			set => SetProperty(ref _npcDeathCollisionComponent, value);
		}

		[Ordinal(10)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetProperty(ref _currentScanType);
			set => SetProperty(ref _currentScanType, value);
		}

		[Ordinal(11)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetProperty(ref _currentScanAnimation);
			set => SetProperty(ref _currentScanAnimation, value);
		}

		public MinotaurMechComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
