using UnityEngine;
using System.Collections.Generic;

public class Ship : MonoBehaviour, IUpgradeable
{

  public GameObject weaponSlotPrefab;

  private GameObject weaponSlot1;

  private GameObject weaponSlot2;

  private GameObject mainCannon;

  [Tooltip("(IUpgradeable) Upgradetypes used: Ship_Shield  Ship_Health  Ship_AddWeaponSlot1  Ship_AddWeaponSlot2")]

  public List<Upgrade> upgrades = new List<Upgrade>();

  private int _startedAtLevel;

  private UpgradeManager upgradeManager;

  private float shield = 1;

  private float health = 1;

  public List<Upgrade> Upgrades // read-write instance property
  {
    get
    {
      return upgrades;
    }
  }

  public int StartedAtLevel
  {
    get
    {
      return _startedAtLevel;
    }
  }

  public Ship()
  {

  }

  void Start()
  {
    upgradeManager = UpgradeManager.getInstance();
    upgradeManager.addUpgradeable(this);
    _startedAtLevel = upgradeManager.level;
  }

  public void Upgrade(Upgrade upgrade)
  {

    switch (upgrade.upgradeType)
    {
      case UpgradeTypes.Ship_Shield:

        shield = upgrade.valueType == UpgradeValueType.Constant ? shield + upgrade.value : shield * upgrade.value;

        break;
      case UpgradeTypes.Ship_Health:
        health = upgrade.valueType == UpgradeValueType.Constant ? shield + upgrade.value : shield * upgrade.value;
        break;

      case UpgradeTypes.Ship_AddWeaponSlot1:
        weaponSlot1 = Instantiate(weaponSlotPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        break;

      case UpgradeTypes.Ship_AddWeaponSlot2:
        weaponSlot2 = Instantiate(weaponSlotPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        break;

    }

  }

}