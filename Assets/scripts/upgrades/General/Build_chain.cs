using Unity.VisualScripting;
using UnityEngine;



public class Build_chain : Global_Upgrade_Base
{
    public float cost;
    public string description;
    public string name;

    public static void UpdateBuildValue()
    {
        if (Global_Upgrade_Manager.UpgradesStatus["First_Build_Chain"])
        {
            Build_Manager.staticBuilds[0].Value += Build_Manager.staticBuilds[0].Amount * 0.1f;
            Build_Manager.staticBuilds[1].Value += Build_Manager.staticBuilds[1].Amount * 0.3f;
            Build_Manager.staticBuilds[2].Value += Build_Manager.staticBuilds[2].Amount * 0.7f;
        }
        if (Global_Upgrade_Manager.UpgradesStatus["Second_Build_Chain"])
        {
            Build_Manager.staticBuilds[3].Value += Build_Manager.staticBuilds[3].Amount * 1f;
            Build_Manager.staticBuilds[4].Value += Build_Manager.staticBuilds[4].Amount * 5f;
            Build_Manager.staticBuilds[5].Value += Build_Manager.staticBuilds[5].Amount * 10f;
        }
        if (Global_Upgrade_Manager.UpgradesStatus["Third_Build_Chain"])
        {
            Build_Manager.staticBuilds[6].Value += Build_Manager.staticBuilds[6].Amount * 100f;
            Build_Manager.staticBuilds[7].Value += Build_Manager.staticBuilds[7].Amount * 200f;
            Build_Manager.staticBuilds[8].Value += Build_Manager.staticBuilds[8].Amount * 500f;
        }
        if (Global_Upgrade_Manager.UpgradesStatus["Fourth_Build_Chain"])
        {
            Build_Manager.staticBuilds[9].Value += Build_Manager.staticBuilds[9].Amount * 0.1f;         
        }


    }  
    public override void CheckAcess(int i)
    {
        switch (i)
        {
            case 2:
                if (Global_Upgrade_Manager.UpgradesStatus["Bonus_Upgrade"] && !Global_Upgrade_Manager.UpgradesStatus["First_Build_Chain"]) 
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    { 
                        Global_Upgrade_Manager.UpgradesStatus["First_Build_Chain"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        cost *= 10;
                    }
                } 
                break;
            case 3:
                if (Global_Upgrade_Manager.UpgradesStatus["First_Build_Chain"]&& !Global_Upgrade_Manager.UpgradesStatus["Second_Build_Chain"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {

                        Global_Upgrade_Manager.UpgradesStatus["Second_Build_Chain"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        cost *= 10;
                    }
                }
                break;
            case 4:
                if (Global_Upgrade_Manager.UpgradesStatus["Second_Build_Chain"]&& !Global_Upgrade_Manager.UpgradesStatus["Third_Build_Chain"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        Global_Upgrade_Manager.UpgradesStatus["Third_Build_Chain"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        cost *= 10;
                    }
                }
                break;
            case 5:
                if (Global_Upgrade_Manager.UpgradesStatus["Third_Build_Chain"]&& !Global_Upgrade_Manager.UpgradesStatus["Fourth_Build_Chain"])
                {
                    if (Neuro.TryToWriteOffScore(cost))
                    {
                        Global_Upgrade_Manager.UpgradesStatus["Fourth_Build_Chain"] = true;
                        Global_Upgrade_Manager.UpdateAllBtnStatus();
                        cost *= 10;
                    }
                }
                break;
        }
        }

    public override void CheckAcess()
    {
        
    }
    public override void ApplyUpgrade()
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







