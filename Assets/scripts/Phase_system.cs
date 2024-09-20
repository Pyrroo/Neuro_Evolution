using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Phase_System : MonoBehaviour
{
    public Phase[] Phases= new Phase[5];
    public static Phase Current_Phase;  
    public static int Current_Phase_Number = 0;
    public float Current_time = 0;
    public Button Test_Button;
    public TextMeshProUGUI Test_Subject_UI, Description_UI, Time_UI, Chance_UI, Cost_UI, Current_phase_UI, Event_UI;

    bool isTesting;

    public static bool isTestingStatic = false;


    bool temp;

    private void Start()
    {
        Current_Phase = Phases[Current_Phase_Number];
        Test_Subject_UI.text = Current_Phase.Test_Subject;
        Description_UI.text = "Суть исследования : " + Current_Phase.Description;
        Time_UI.text = "Время тестировки: " + Current_Phase.Test_Time.ToString();
        Cost_UI.text = "Стоимость: " + Current_Phase.Test_Cost.ToString("N0");
        Current_phase_UI.text = "Текущая фаза: " + Current_Phase_Number.ToString();
    }
    public void StartTest()  
    {
        if (Neuro.TryToWriteOffScore(Current_Phase.Test_Cost))
        {
            isTesting = true;
            Test_Button.interactable = false;
            Testing();
        }
    }


    public void Testing()
    {
        StartCoroutine(HandleEvent());       
    }
    private IEnumerator HandleEvent()
    {
        isTesting = true;
        double successChance = (double)Neuro.allScore / (Neuro.allScore + Current_Phase.Difficulty_Modifier * (Neuro.ScorePerSecond)) * 100;
        isTestingStatic= true;
        Event_UI.text = "Идёт новая тестировка";
        yield return new WaitForSeconds(Current_Phase.Test_Time);
        Event_UI.text = "Сейчас ничего не происходит";
        if (Random.value < successChance)
        {
            Phases[Current_Phase_Number].completed = true;
            Current_Phase_Number++;
            Current_Phase = Phases[Current_Phase_Number];
            Test_Subject_UI.text = Current_Phase.Test_Subject;
            Description_UI.text = Current_Phase.Description;
            Time_UI.text = "Время тестировки: " + Current_Phase.Test_Time.ToString();
            Cost_UI.text = "Стоимость: " + Current_Phase.Test_Cost.ToString("N0");
            Current_phase_UI.text = "Текущая фаза: " + Current_Phase_Number.ToString();
        }

        Test_Button.interactable = true;
        isTesting = false;
    }
    private IEnumerator UpdateText()
    {
        temp = true;

        yield return new WaitForSeconds(5);

        temp = false;
    }

    private void Update()
    {
        double successChance = (double)Neuro.allScore / (Neuro.allScore + Current_Phase.Difficulty_Modifier * (Neuro.ScorePerSecond)) * 100;
        Chance_UI.text = "Шанс на успех : " + successChance.ToString();       
        StartCoroutine(UpdateText());
        
    }
}
