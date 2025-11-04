# Upgrade-System 

This is a prototype for the latest version of my upgrade-system.

### This version is improved by:

Game elements informing the system of its upgrades

Avoiding Upgrade-system having knowledge of specific game elements.

A seamless upgrade flow for game elements.

The project contains the upgrade-system and a very simple demo setup. The demo setup does not contain any gameplay or interaction, but only contains placeholder game elements with some upgrades.

## The Upgrade-system contains these key elements:

IUpgradeable interface

Upgrade class

UpgradeManager

UpgradeTypes


## Usage:
Game elements (GameObjects or just plain classes) implements the IUpgradeable interface and the following signature:

List<Upgrade> - a list of the elements upgrades, these are easiest to create in the Unity inspector.

void Upgrade(upgrade Upgrade) method - this method receives an upgrade selected by the player.

int startedAtLevel - this is set using upgradeManager.level when the game element is "startet" marking the zero point for "relative to start" upgrades.


## Adding IUpgradeable instance to the UpgradeManager.
The UpgradeManager is implemented as a singleton and the instance can be received by UpgradeManager.getInstance();

To add a element to the UpgradeManager use upgradeManager.addUpgradeable(this) and in the case you want to remove them use  upgradeManager.removeUpgradeable(this);

## Upgrade:
An Upgrade contains meta data for the upgrade, used by the upgradeManager logic, the element implementation and choice UI.

The UpgradeManager handles all logic; when upgrades should be surgested and how many times they can occur

## Upgrade-types enum:
These are the upgrades, the list is expanded as needed, and the types can be used across different elements, generic or specific types are both ok.










