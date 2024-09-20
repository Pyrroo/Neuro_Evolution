using UnityEngine;
using UnityEngine.UI;

public class Hacker_Event : Event_Base
{
    public float Event_time;

    
    public override string GetDescription()
    {
        return "Ваши сервера атакуют хакеры";
    }
    public override void StartEvent()
    {
        Debug.Log("Сработал ивент с Хакерской атакой");
        Neuro.ScorePerSecond *= 0.5f;
        
    }
    public override void EndEvent()
    {
        Debug.Log("Ивент с Хакерской атакой закончен");
        Neuro.ScorePerSecond *= 2.0f;

    }
    public override float GetTime()
    {
        return Event_time;
    }
}
