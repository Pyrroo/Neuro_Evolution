using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Build_Info : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public int button_number;
    public TextMeshProUGUI Name_UI, Description_UI, Cost_UI, Value_UI;

    
    public void OnPointerClick(PointerEventData eventData)
    {
        Name_UI.text = Build_Manager.staticBuilds[button_number].BuildName;
        Description_UI.text = Build_Manager.staticBuilds[button_number].Description;
        Cost_UI.text = "Стоимость : " + Build_Manager.staticBuilds[button_number].Cost.ToString("N0");
        Value_UI.text = "Прибыль : " + (Build_Manager.staticBuilds[button_number].Value * Build_Manager.staticBuilds[button_number].Value_multiplaer).ToString("N0");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Name_UI.text = Build_Manager.staticBuilds[button_number].BuildName;
        Description_UI.text = Build_Manager.staticBuilds[button_number].Description;
        Cost_UI.text = "Стоимость : " + Build_Manager.staticBuilds[button_number].Cost.ToString("N0");
        Value_UI.text = "Прибыль : " + (Build_Manager.staticBuilds[button_number].Value * Build_Manager.staticBuilds[button_number].Value_multiplaer).ToString("N0");

    }

   
    public void OnPointerExit(PointerEventData eventData)
    {
        Name_UI.text = "";
        Description_UI.text = "";
        Cost_UI.text = "";
        Value_UI.text = "";
    }
}
