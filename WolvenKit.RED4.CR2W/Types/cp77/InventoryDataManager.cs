using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryDataManager : IScriptable
	{
		private ScriptGameInstance _gameInstance;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private CHandle<UILocalizationMap> _locMgr;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("equipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(4)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(5)] 
		[RED("locMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get => GetProperty(ref _locMgr);
			set => SetProperty(ref _locMgr, value);
		}

		public InventoryDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
