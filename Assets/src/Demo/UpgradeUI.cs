using System.Collections.Generic;
using UnityEngine;

public class UpgradeUI : MonoBehaviour, IUpgradeUI
{

    private UpgradeManager upgradeManager;

    private List<Upgrade> currentUpgrades;

    private bool gamePaused = false;

    void Start()
    {
        upgradeManager = UpgradeManager.getInstance();
        upgradeManager.upgradeUI = this;
    }

    void Update()
    {
        upgradeManager.addXp();
    }

    public void ShowChoices(List<Upgrade> upgrades)
    {
        Debug.Log("------------- Show Choices ---------------");
        Debug.Log("upgrade1: " + upgrades[0].heading + " owner: " + upgrades[0].owner);
        Debug.Log("upgrade2: " + upgrades[1].heading + " owner: " + upgrades[1].owner);
        Debug.Log("upgrade3: " + upgrades[2].heading + " owner: " + upgrades[2].owner);

        int choice = (int)Random.Range(0, 2);
        Debug.Log("--- upgrade selected: " + choice);
        upgradeManager.UpgradeSelected(upgrades[choice]);

    }


}