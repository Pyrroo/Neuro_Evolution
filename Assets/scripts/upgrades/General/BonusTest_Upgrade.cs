using UnityEngine;


public class BonusTest_Upgrade : Global_Upgrade_Base
{
    public float cost;
    public string description;
    public string name;

    public override void ApplyUpgrade()
    {
        Global_Upgrade_Manager.UpgradesStatus["Bonus_Upgrade"] = true;
        Global_Upgrade_Manager.UpdateAllBtnStatus();

    }

    public override void CheckAcess()
    {
        if (Global_Upgrade_Manager.UpgradesStatus["First_Upgrade"])
        {
            if (Neuro.TryToWriteOffScore(cost))
                ApplyUpgrade();
            Debug.Log("Можно");
        }
        else
        {
            Debug.Log("Низя");
        }
    }
    public override void CheckAcess(int i)
    {

    }

    public override string GetUpgradeCost()
    {        
        return cost.ToString();
    }

    public override string GetUpgradeDescription()
    {
        return description;
    }

    public override string GetUpgradeName()
    {
        return name;
    }
}
