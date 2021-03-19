using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _haskMarkContainer;
		private inkCompoundWidgetReference _itemContainer;
		private inkWidgetReference _selectorWrapper;
		private inkWidgetReference _centerIcon;
		private inkWidgetReference _centerGlow;
		private inkTextWidgetReference _itemLabel;
		private inkTextWidgetReference _itemDesc;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkImageWidgetReference _indicator02;
		private inkImageWidgetReference _indicator03;
		private inkImageWidgetReference _indicator04;
		private inkImageWidgetReference _indicator05;
		private inkImageWidgetReference _indicator06;
		private inkImageWidgetReference _indicator07;
		private inkImageWidgetReference _indicator08;
		private CFloat _itemDistance;
		private CFloat _hashMarkDistance;
		private CFloat _minDistance;
		private CHandle<inkWidget> _root;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CArray<CHandle<DpadWheelItemController>> _dpadItemsList;
		private CArray<QuickSlotCommand> _commandsList;
		private wCHandle<DpadWheelItemController> _selectedWheelItem;
		private wCHandle<ButtonHints> _buttonHintsController;
		private inkWidgetReference _selectedIndicator;
		private CFloat _angleInterval;
		private CFloat _previousAmount;
		private CFloat _previousAngle;
		private QuickWheelStartUIStructure _data;
		private CArray<AbilityData> _masterListOfAllCyberware;
		private CArray<AbilityData> _listOfUnassignedCyberware;
		private CBool _dpadWheelOpen;
		private gameDelayID _neutralChoiceDelayId;
		private QuickSlotCommand _previouslySelectedData;
		private CHandle<gameIBlackboard> _uiQuickItemsBlackboard;
		private CHandle<UI_QuickSlotsDataDef> _uiQuickSlotDef;
		private CUInt32 _dPadWheelAngleBBID;
		private CUInt32 _dPadWheelInterationStartedBBID;
		private CUInt32 _dPadWheelInterationEndedBBID;
		private CUInt32 _dpadWheelCyberwareAssignedBBID;

		[Ordinal(3)] 
		[RED("haskMarkContainer")] 
		public inkCompoundWidgetReference HaskMarkContainer
		{
			get => GetProperty(ref _haskMarkContainer);
			set => SetProperty(ref _haskMarkContainer, value);
		}

		[Ordinal(4)] 
		[RED("itemContainer")] 
		public inkCompoundWidgetReference ItemContainer
		{
			get => GetProperty(ref _itemContainer);
			set => SetProperty(ref _itemContainer, value);
		}

		[Ordinal(5)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get => GetProperty(ref _selectorWrapper);
			set => SetProperty(ref _selectorWrapper, value);
		}

		[Ordinal(6)] 
		[RED("centerIcon")] 
		public inkWidgetReference CenterIcon
		{
			get => GetProperty(ref _centerIcon);
			set => SetProperty(ref _centerIcon, value);
		}

		[Ordinal(7)] 
		[RED("centerGlow")] 
		public inkWidgetReference CenterGlow
		{
			get => GetProperty(ref _centerGlow);
			set => SetProperty(ref _centerGlow, value);
		}

		[Ordinal(8)] 
		[RED("itemLabel")] 
		public inkTextWidgetReference ItemLabel
		{
			get => GetProperty(ref _itemLabel);
			set => SetProperty(ref _itemLabel, value);
		}

		[Ordinal(9)] 
		[RED("itemDesc")] 
		public inkTextWidgetReference ItemDesc
		{
			get => GetProperty(ref _itemDesc);
			set => SetProperty(ref _itemDesc, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(11)] 
		[RED("indicator02")] 
		public inkImageWidgetReference Indicator02
		{
			get => GetProperty(ref _indicator02);
			set => SetProperty(ref _indicator02, value);
		}

		[Ordinal(12)] 
		[RED("indicator03")] 
		public inkImageWidgetReference Indicator03
		{
			get => GetProperty(ref _indicator03);
			set => SetProperty(ref _indicator03, value);
		}

		[Ordinal(13)] 
		[RED("indicator04")] 
		public inkImageWidgetReference Indicator04
		{
			get => GetProperty(ref _indicator04);
			set => SetProperty(ref _indicator04, value);
		}

		[Ordinal(14)] 
		[RED("indicator05")] 
		public inkImageWidgetReference Indicator05
		{
			get => GetProperty(ref _indicator05);
			set => SetProperty(ref _indicator05, value);
		}

		[Ordinal(15)] 
		[RED("indicator06")] 
		public inkImageWidgetReference Indicator06
		{
			get => GetProperty(ref _indicator06);
			set => SetProperty(ref _indicator06, value);
		}

		[Ordinal(16)] 
		[RED("indicator07")] 
		public inkImageWidgetReference Indicator07
		{
			get => GetProperty(ref _indicator07);
			set => SetProperty(ref _indicator07, value);
		}

		[Ordinal(17)] 
		[RED("indicator08")] 
		public inkImageWidgetReference Indicator08
		{
			get => GetProperty(ref _indicator08);
			set => SetProperty(ref _indicator08, value);
		}

		[Ordinal(18)] 
		[RED("itemDistance")] 
		public CFloat ItemDistance
		{
			get => GetProperty(ref _itemDistance);
			set => SetProperty(ref _itemDistance, value);
		}

		[Ordinal(19)] 
		[RED("hashMarkDistance")] 
		public CFloat HashMarkDistance
		{
			get => GetProperty(ref _hashMarkDistance);
			set => SetProperty(ref _hashMarkDistance, value);
		}

		[Ordinal(20)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(22)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(23)] 
		[RED("QuickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(24)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(25)] 
		[RED("dpadItemsList")] 
		public CArray<CHandle<DpadWheelItemController>> DpadItemsList
		{
			get => GetProperty(ref _dpadItemsList);
			set => SetProperty(ref _dpadItemsList, value);
		}

		[Ordinal(26)] 
		[RED("commandsList")] 
		public CArray<QuickSlotCommand> CommandsList
		{
			get => GetProperty(ref _commandsList);
			set => SetProperty(ref _commandsList, value);
		}

		[Ordinal(27)] 
		[RED("selectedWheelItem")] 
		public wCHandle<DpadWheelItemController> SelectedWheelItem
		{
			get => GetProperty(ref _selectedWheelItem);
			set => SetProperty(ref _selectedWheelItem, value);
		}

		[Ordinal(28)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(29)] 
		[RED("selectedIndicator")] 
		public inkWidgetReference SelectedIndicator
		{
			get => GetProperty(ref _selectedIndicator);
			set => SetProperty(ref _selectedIndicator, value);
		}

		[Ordinal(30)] 
		[RED("angleInterval")] 
		public CFloat AngleInterval
		{
			get => GetProperty(ref _angleInterval);
			set => SetProperty(ref _angleInterval, value);
		}

		[Ordinal(31)] 
		[RED("previousAmount")] 
		public CFloat PreviousAmount
		{
			get => GetProperty(ref _previousAmount);
			set => SetProperty(ref _previousAmount, value);
		}

		[Ordinal(32)] 
		[RED("previousAngle")] 
		public CFloat PreviousAngle
		{
			get => GetProperty(ref _previousAngle);
			set => SetProperty(ref _previousAngle, value);
		}

		[Ordinal(33)] 
		[RED("data")] 
		public QuickWheelStartUIStructure Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(34)] 
		[RED("masterListOfAllCyberware")] 
		public CArray<AbilityData> MasterListOfAllCyberware
		{
			get => GetProperty(ref _masterListOfAllCyberware);
			set => SetProperty(ref _masterListOfAllCyberware, value);
		}

		[Ordinal(35)] 
		[RED("listOfUnassignedCyberware")] 
		public CArray<AbilityData> ListOfUnassignedCyberware
		{
			get => GetProperty(ref _listOfUnassignedCyberware);
			set => SetProperty(ref _listOfUnassignedCyberware, value);
		}

		[Ordinal(36)] 
		[RED("dpadWheelOpen")] 
		public CBool DpadWheelOpen
		{
			get => GetProperty(ref _dpadWheelOpen);
			set => SetProperty(ref _dpadWheelOpen, value);
		}

		[Ordinal(37)] 
		[RED("neutralChoiceDelayId")] 
		public gameDelayID NeutralChoiceDelayId
		{
			get => GetProperty(ref _neutralChoiceDelayId);
			set => SetProperty(ref _neutralChoiceDelayId, value);
		}

		[Ordinal(38)] 
		[RED("previouslySelectedData")] 
		public QuickSlotCommand PreviouslySelectedData
		{
			get => GetProperty(ref _previouslySelectedData);
			set => SetProperty(ref _previouslySelectedData, value);
		}

		[Ordinal(39)] 
		[RED("UiQuickItemsBlackboard")] 
		public CHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetProperty(ref _uiQuickItemsBlackboard);
			set => SetProperty(ref _uiQuickItemsBlackboard, value);
		}

		[Ordinal(40)] 
		[RED("UiQuickSlotDef")] 
		public CHandle<UI_QuickSlotsDataDef> UiQuickSlotDef
		{
			get => GetProperty(ref _uiQuickSlotDef);
			set => SetProperty(ref _uiQuickSlotDef, value);
		}

		[Ordinal(41)] 
		[RED("DPadWheelAngleBBID")] 
		public CUInt32 DPadWheelAngleBBID
		{
			get => GetProperty(ref _dPadWheelAngleBBID);
			set => SetProperty(ref _dPadWheelAngleBBID, value);
		}

		[Ordinal(42)] 
		[RED("DPadWheelInterationStartedBBID")] 
		public CUInt32 DPadWheelInterationStartedBBID
		{
			get => GetProperty(ref _dPadWheelInterationStartedBBID);
			set => SetProperty(ref _dPadWheelInterationStartedBBID, value);
		}

		[Ordinal(43)] 
		[RED("DPadWheelInterationEndedBBID")] 
		public CUInt32 DPadWheelInterationEndedBBID
		{
			get => GetProperty(ref _dPadWheelInterationEndedBBID);
			set => SetProperty(ref _dPadWheelInterationEndedBBID, value);
		}

		[Ordinal(44)] 
		[RED("DpadWheelCyberwareAssignedBBID")] 
		public CUInt32 DpadWheelCyberwareAssignedBBID
		{
			get => GetProperty(ref _dpadWheelCyberwareAssignedBBID);
			set => SetProperty(ref _dpadWheelCyberwareAssignedBBID, value);
		}

		public DpadWheelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
