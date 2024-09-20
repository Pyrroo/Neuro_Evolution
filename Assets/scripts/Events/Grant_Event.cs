using UnityEngine;
using UnityEngine.UI;



public class Grant_Event : Event_Base
{
    public float value = 300;
    public float Event_time;    
    public override string GetDescription()
    {
        return "Вам выдан грант на развитие";
    }

    public override void StartEvent()
    {
        Debug.Log("Сработал ивент с грантом");
        Neuro.AddScore(Neuro.ScorePerSecond* value);
    }

    public override void EndEvent()
    {
        
    }
    public override float GetTime()
    {
        return Event_time;
    }

}
