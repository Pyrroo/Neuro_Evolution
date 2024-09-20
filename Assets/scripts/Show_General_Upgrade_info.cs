using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Show_General_Upgrade_info : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject panel;
    public Canvas canvas; // —сылка на канвас   
    public RectTransform canvasRectTransform; // RectTransform канваса
    public TextMeshProUGUI Name_UI, Decription_UI, Cost_UI;

    public string name, description, cost;

    private void Start()
    {
        panel.SetActive(false);
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {       
        Vector2 mousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, canvas.worldCamera, out mousePosition);
        Vector3 localPosition = new Vector3(mousePosition.x + 90f, mousePosition.y + 15, 0f);
        panel.SetActive(true);
        panel.transform.localPosition = localPosition;
        Name_UI.text = name;
        Decription_UI.text = description;
        Cost_UI.text = cost;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        panel.SetActive(false);
    }
}
