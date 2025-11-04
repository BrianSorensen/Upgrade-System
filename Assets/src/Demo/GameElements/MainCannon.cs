using UnityEngine;
using System.Collections.Generic;

public class MainCannon : MonoBehaviour, IUpgradeable
{
    [Tooltip("(IUpgradeable) Weapon_ShotFreq  Weapon_Damage  Weapon_AddShot")] public List<Upgrade> upgrades = new List<Upgrade>();

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

    public MainCannon()
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
            case UpgradeTypes.Weapon_ShotFreq:
                // code block
                break;

            case UpgradeTypes.Weapon_Damage:
                // code block
                break;

            case UpgradeTypes.Weapon_AddShot:
                // code block
                break;


        }

    }

}