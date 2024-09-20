using UnityEngine;


public class Build_Upgrade : Base_Upgrade_class
{
    public string upgradeName;
    public string description;
    public float cost;
    public int stage;
    public int Build_index;

    public override void applyUpgrade()
    {
        if (Neuro.TryToWriteOffScore(cost))
        {
            Debug.Log("Куплено улучшение для " + Build_index.ToString() + " здания");
            Build_Manager.staticBuilds[Build_index].Value_multiplaer++;
            Neuro.UpdateSPS();
            cost *= 3;
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
