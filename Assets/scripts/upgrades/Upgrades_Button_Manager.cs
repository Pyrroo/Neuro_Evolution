using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Upgrades_Button_Manager : MonoBehaviour
{


    public List<Base_Upgrade_class> tempList = new();
    public static Base_Upgrade_class[] Upgrade_List = new Base_Upgrade_class[11];

    public void BuyUpgrade(int i)
    {
        Upgrade_List[i].applyUpgrade();
    }
    private void Start()
    {
        
        for (int i = 0; i < tempList.Count; i++)
        {
            Upgrade_List[i] = tempList[i];
        }


        
    }

}
