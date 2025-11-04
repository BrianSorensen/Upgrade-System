using UnityEngine;
using System.Collections.Generic;

public class WeaponSlot : MonoBehaviour, IUpgradeable
{
  [Tooltip("(IUpgradeable) WeaponSlot_UpgradeWeapon")] public List<Upgrade> upgrades = new List<Upgrade>();

  private int _startedAtLevel;

  private UpgradeManager upgradeManager;

  public List<Upgrade> Upgrades
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

  public WeaponSlot()
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
      case UpgradeTypes.WeaponSlot_UpgradeWeapon:
        // code block
        break;


    }

  }

}