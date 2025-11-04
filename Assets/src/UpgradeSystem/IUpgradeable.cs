using System.Collections.Generic;

public interface IUpgradeUI
{
  void ShowChoices(List<Upgrade> upgrades);
}

public interface IUpgradeable
{

  List<Upgrade> Upgrades
  {
    get;
  }

  int StartedAtLevel
  {
    get;
  }

  void Upgrade(Upgrade upgrade);
}