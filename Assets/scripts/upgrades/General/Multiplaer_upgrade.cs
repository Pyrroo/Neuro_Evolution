using Unity.VisualScripting;
using UnityEngine;


public class Multiplaer_upgrade : Global_Upgrade_Base
{
    public float cost;
    public float multiplier;
    public string description;
    public string name;

    public override void ApplyUpgrade()
    {
        Neuro.SPSMultiplaer += multiplier;
        Neuro.UpdateSPS();
    }
    public override void CheckAcess(int i)
    {
        switch (i)
        {
            case 1:
                if (Global_Upgrade_Manager.UpgradesStatus["First_Upgrade"] && !Global_Upgrade_Manager.UpgradesStatus["First_Multi"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["First_Multi"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        multiplier += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 2:
                if (Global_Upgrade_Manager.UpgradesStatus["First_Multi"] && !Global_Upgrade_Manager.UpgradesStatus["Second_Multi"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Second_Multi"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        multiplier += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 3:
                if (Global_Upgrade_Manager.UpgradesStatus["Second_Multi"] && !Global_Upgrade_Manager.UpgradesStatus["Third_Multi"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Third_Multi"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        multiplier += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 4:
                if (Global_Upgrade_Manager.UpgradesStatus["Third_Multi"] && !Global_Upgrade_Manager.UpgradesStatus["Fourth_Multi"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Fourth_Multi"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        multiplier += 0.15f;
                        cost *= 10;
                    }
                }
                break;
            case 5:
                if (Global_Upgrade_Manager.UpgradesStatus["Fourth_Multi"] && !Global_Upgrade_Manager.UpgradesStatus["Fifth_Multi"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        ApplyUpgrade();
                        Global_Upgrade_Manager.UpgradesStatus["Fifth_Multi"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        multiplier += 0.15f;
                        cost *= 100;
                    }
                }
                break;
        }
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
