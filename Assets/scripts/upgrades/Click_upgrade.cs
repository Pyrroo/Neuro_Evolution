using UnityEngine;


public class Click_upgrade : Base_Upgrade_class
{
    public float cost = 100;
    public string upgradeName;
    public string description;
    public float value = 1;
    public int stage = 0;

    public override void applyUpgrade()
    {
        if (Neuro.TryToWriteOffScore(cost))
        {
            Debug.Log("Куплено улучшение для мышки");
            Neuro.ClickMultiplaer *= value;
            cost *= 4;
            stage++;
        }
        
    }
    public override string GetStage()
    {
        return stage.ToString();
    }
    public override string GetDescription()
    {
        return description;
    }
    public override float GetCost()
    {
        return cost;
    }
    public override string GetName()
    {
        return upgradeName;
    }


}
