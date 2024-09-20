using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using NUnit.Framework;
using UnityEngine.UI;
using TMPro;

public class Event_Manager : MonoBehaviour
{
    public List<Event_Base> events = new();
    public float Event_Timer = 0;
    private bool eventActive = false;
    public TextMeshProUGUI Event_Text;


    
    System.Random rand = new System.Random();


    private void Start()
    {
        Event_Text.text = "Сейчас ничего не происходит";
    }

    private void Update()
    {
        if (Global_Upgrade_Manager.UpgradesStatus["Event_Upgrade"] && !Phase_System.isTestingStatic)
        {
            Event_Timer += Time.deltaTime;
            if (Event_Timer > 100)
            {
                StartCoroutine(HandleEvent());
                Event_Timer = 0;
            }
        }
        
    }
    private IEnumerator HandleEvent()
    {
        eventActive = true;
        int randomIndex = rand.Next(events.Count);
        events[randomIndex].StartEvent();
        Event_Text.text = events[randomIndex].GetDescription();
        yield return new WaitForSeconds(events[randomIndex].GetTime());
        Event_Text.text = "Сейчас ничего не происходит";
        events[randomIndex].EndEvent();
        eventActive = false;
    }
}
