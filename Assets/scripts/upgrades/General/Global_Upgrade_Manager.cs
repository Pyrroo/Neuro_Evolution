using UnityEngine;


using System.Collections;
using System.Collections.Generic;

public class Global_Upgrade_Manager : MonoBehaviour
{
    
    public static Dictionary<string, bool> UpgradesStatus = new();

    public List<UI_Lock_button> BtnLockList = new();
    public static List<UI_Lock_button> StaticBtnLockList = new();
    
    

    private void Start()
    {   
        // Определение всех глобал апгрейдов
        UpgradesStatus.Add("First_Upgrade", false);
        UpgradesStatus.Add("Event_Upgrade", false);
        UpgradesStatus.Add("Bonus_Upgrade", false);

        UpgradesStatus.Add("First_Multi", false);
        UpgradesStatus.Add("Second_Multi", false);
        UpgradesStatus.Add("Third_Multi", false);
        UpgradesStatus.Add("Fourth_Multi", false);
        UpgradesStatus.Add("Fifth_Multi", false);


        UpgradesStatus.Add("First_Build_Chain", false);
        UpgradesStatus.Add("Second_Build_Chain", false);
        UpgradesStatus.Add("Third_Build_Chain", false);
        UpgradesStatus.Add("Fourth_Build_Chain", false);

        UpgradesStatus.Add("Second_AC", false);
        UpgradesStatus.Add("Third_AC", false);
        UpgradesStatus.Add("Fourth_AC", false);
        UpgradesStatus.Add("Fifth_AC", false);



        for (int i = 0; i < BtnLockList.Count; i++)
        {
            StaticBtnLockList.Add(BtnLockList[i]);
        }
        
    }
    
    public static void UpdateAllBtnStatus()
    {
        for (int i = 0; i < StaticBtnLockList.Count; i++)
        {
            StaticBtnLockList[i].TryUnlock();
        }
    }

}
