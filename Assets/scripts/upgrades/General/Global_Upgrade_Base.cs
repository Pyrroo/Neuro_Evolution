using UnityEngine;


public abstract class Global_Upgrade_Base : MonoBehaviour
{ 
    public abstract void ApplyUpgrade();    
    public abstract void CheckAcess();
    public abstract void CheckAcess(int i);
    public abstract string GetUpgradeName();
    public abstract string GetUpgradeDescription();
    public abstract string GetUpgradeCost();



}
