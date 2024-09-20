using UnityEngine;
using UnityEngine.UI;


public class Article_Event : Event_Base
{
    public float Event_time;  
    public override string GetDescription()
    {
        return "Про вас написали статью";
    }
    public override void StartEvent()
    {
        Debug.Log("Сработал ивент с Статьей");
        Neuro.ScorePerSecond*= 2;
        //Neuro.score += Neuro.ScorePerSecond * Time.deltaTime;
    }
    public override void EndEvent()
    {
        Debug.Log("Ивент со статьей закончен");
        Neuro.ScorePerSecond /= 2;        
    }
    public override float GetTime()
    {
        return Event_time;
    }
}
