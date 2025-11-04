using System.Collections.Generic;

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