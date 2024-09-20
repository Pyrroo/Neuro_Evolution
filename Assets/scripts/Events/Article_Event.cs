using UnityEngine;
using UnityEngine.UI;


public class Article_Event : Event_Base
{
    public float Event_time;  
    public override string GetDescription()
    {
        return "��� ��� �������� ������";
    }
    public override void StartEvent()
    {
        Debug.Log("�������� ����� � �������");
        Neuro.ScorePerSecond*= 2;
        //Neuro.score += Neuro.ScorePerSecond * Time.deltaTime;
    }
    public override void EndEvent()
    {
        Debug.Log("����� �� ������� ��������");
        Neuro.ScorePerSecond /= 2;        
    }
    public override float GetTime()
    {
        return Event_time;
    }
}
