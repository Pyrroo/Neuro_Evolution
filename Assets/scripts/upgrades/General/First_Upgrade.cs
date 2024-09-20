using Unity.VisualScripting;
using UnityEngine;


public class First_upgrade : Global_Upgrade_Base
{
    public float cost;
    public string description;
    public string name;
    public override void ApplyUpgrade()
    {
        Neuro.SPSMultiplaer += 0.15f;
        Neuro.UpdateSPS();
        Global_Upgrade_Manager.UpgradesStatus["First_Upgrade"] = true;
        Global_Upgrade_Manager.UpdateAllBtnStatus();
    }
    public override void CheckAcess()
    {
        if(Phase_System.Current_Phase_Number >= 0)
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
