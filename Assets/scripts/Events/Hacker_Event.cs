using UnityEngine;
using UnityEngine.UI;

public class Hacker_Event : Event_Base
{
    public float Event_time;

    
    public override string GetDescription()
    {
        return "���� ������� ������� ������";
    }
    public override void StartEvent()
    {
        Debug.Log("�������� ����� � ��������� ������");
        Neuro.ScorePerSecond *= 0.5f;
        
    }
    public override void EndEvent()
    {
        Debug.Log("����� � ��������� ������ ��������");
        Neuro.ScorePerSecond *= 2.0f;

    }
    public override float GetTime()
    {
        return Event_time;
    }
}
