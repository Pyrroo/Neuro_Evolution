using UnityEngine;


public abstract class Event_Base : MonoBehaviour
{
    public abstract float GetTime();
    public abstract string GetDescription();
    public abstract void StartEvent();
    public abstract void EndEvent();
        
    
}
