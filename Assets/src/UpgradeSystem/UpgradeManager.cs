using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;


[System.Serializable]
public class UpgradeManager
{

    private static UpgradeManager instance;

    public int level = 0;

    public int currentXP = 0;

    public int nextLevel = 15;
    public int nextLevelSpeed = 15;

    public float levelMultiplier = 1.07f;

    public IUpgradeUI upgradeUI;

    private List<IUpgradeable> activeUpgradeables = new List<IUpgradeable>();

    private List<Upgrade> currentUpgrades;

    public static UpgradeManager getInstance()
    {
        if (instance == null)
        {
            instance = new UpgradeManager();
        }
        return instance;
    }

    public void addXp()
    {

        currentXP += 1;

        if (currentXP > nextLevel)
        {

            currentUpgrades = collectUpgrades().OrderBy(x => Guid.NewGuid()).Take(3).ToList();

            nextLevel += nextLevelSpeed;
            nextLevelSpeed = Mathf.RoundToInt((float)nextLevelSpeed * levelMultiplier);
            if (currentUpgrades.Count == 3)
            {
                upgradeUI.ShowChoices(currentUpgrades);
            }
            else
            {
                Debug.Log("----- Game out of upgrades");
            }
        }
    }

    public void UpgradeSelected(Upgrade upgrade)
    {
        upgrade.currentCount += 1;
        upgrade.owner.Upgrade(upgrade);
    }

    public void addUpgradeable(IUpgradeable upgradeable)
    {
        activeUpgradeables.Add(upgradeable);
    }

    public void removeUpgradeable(IUpgradeable upgradeable)
    {
        activeUpgradeables.Remove(upgradeable);

    }

    private List<Upgrade> collectUpgrades()
    {
        List<Upgrade> upgrades = new List<Upgrade>();

        for (int i = 0; i < activeUpgradeables.Count; i++)
        {
            for (int j = 0; j < activeUpgradeables[i].Upgrades.Count; j++)
            {
                Upgrade up = activeUpgradeables[i].Upgrades[j];
                up.owner = activeUpgradeables[i];
                int upgradeStartLevel = up.startLevelValue == StartLevelValue.Constant ? up.startLevel : up.owner.StartedAtLevel + up.startLevel;
                if ((level >= upgradeStartLevel) && (up.maxCount > up.currentCount))
                {
                    upgrades.Add(up);
                }
            }
        }
        return upgrades;
    }

}