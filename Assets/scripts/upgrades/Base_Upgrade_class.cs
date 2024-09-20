using UnityEngine;


public abstract class Base_Upgrade_class : MonoBehaviour
{
    public abstract string GetDescription();
    public abstract float GetCost();
    public abstract string GetName();
    public abstract string GetStage();
    public abstract void applyUpgrade();    

}
