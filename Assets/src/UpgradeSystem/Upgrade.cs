using UnityEngine;
public enum UpgradeValueType
{
  Constant,
  Procentage
}

public enum UpgradeValue
{
  Normal,
  Rare,
  High
}

public enum StartLevelValue
{
  Constant,
  RelativeToStart
}

[System.Serializable]
public class Upgrade
{

  public int startLevel;

  public StartLevelValue startLevelValue;

  public UpgradeTypes upgradeType;

  public IUpgradeable owner;

  public float value;

  public UpgradeValueType valueType;

  public int maxCount = 1;

  [HideInInspector] public int currentCount = 0;


  //---- properties used for UI ------------
  public UpgradeValue upgradeValue;

  public string heading;

  public string desc;

  public Texture icon;

}