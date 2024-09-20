using Unity.VisualScripting;
using UnityEngine;


public class DoubleClick_Upgrade : Global_Upgrade_Base
{
    public float cost;
    public static float DoubleChance = 0;
    public static float TripleChance = 0;
    public static float quadrupleChance = 0;
    public string description;
    public string name;


    public override void CheckAcess(int i)
    {
        switch (i)
        {
            case 2:
                if (Global_Upgrade_Manager.UpgradesStatus["Bonus_Upgrade"] && !Global_Upgrade_Manager.UpgradesStatus["Second_AC"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Second_AC"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        DoubleChance += 0.15f;
                        
                        cost *= 10;
                    }
                }
                break;
            case 3:
                if (Global_Upgrade_Manager.UpgradesStatus["Second_AC"] && !Global_Upgrade_Manager.UpgradesStatus["Third_AC"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Third_AC"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        DoubleChance += 0.15f;
                        TripleChance += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 4:
                if (Global_Upgrade_Manager.UpgradesStatus["Third_AC"] && !Global_Upgrade_Manager.UpgradesStatus["Fourth_AC"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Fourth_AC"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        DoubleChance += 0.15f;
                        TripleChance += 0.15f;
                        quadrupleChance += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 5:
                if (Global_Upgrade_Manager.UpgradesStatus["Fourth_AC"] && !Global_Upgrade_Manager.UpgradesStatus["Fifth_AC"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Fifth_AC"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        DoubleChance += 0.15f;
                        TripleChance += 0.15f;
                        quadrupleChance += 0.15f;
                        cost *= 10;
                    }
                }
                break;
        }
    }
    public override void ApplyUpgrade()
    {

    }
    public override void CheckAcess()
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
