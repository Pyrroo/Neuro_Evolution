using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Upgrade_Info : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public int button_number;
    public TextMeshProUGUI Name_UI, Description_UI, Cost_UI, Value_UI;


    public void OnPointerClick(PointerEventData eventData)
    {
        Name_UI.text = Upgrades_Button_Manager.Upgrade_List[button_number].GetName();
        Description_UI.text = Upgrades_Button_Manager.Upgrade_List[button_number].GetDescription();
        Cost_UI.text = "Стоимость : " + Upgrades_Button_Manager.Upgrade_List[button_number].GetCost().ToString("N0");
        Value_UI.text = "Количество изучений : " + Upgrades_Button_Manager.Upgrade_List[button_number].GetStage();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Name_UI.text = Upgrades_Button_Manager.Upgrade_List[button_number].GetName();
        Description_UI.text = Upgrades_Button_Manager.Upgrade_List[button_number].GetDescription();
        Cost_UI.text = "Стоимость : " + Upgrades_Button_Manager.Upgrade_List[button_number].GetCost().ToString("N0");
        Value_UI.text = "Количество изучений : " + Upgrades_Button_Manager.Upgrade_List[button_number].GetStage();

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Name_UI.text = "";
        Description_UI.text = "";
        Cost_UI.text = "";
        Value_UI.text = "";
    }
}
