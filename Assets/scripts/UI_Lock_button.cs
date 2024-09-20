using UnityEngine;

using UnityEngine.UI;

public class UI_Lock_button : MonoBehaviour
{
    public string Need;
    private Image img;
    private Button btnRef;
    private void Start()
    {
        img = gameObject.GetComponent<Image>();
        btnRef = gameObject.GetComponent<Button>();
        LockButton();
    }
    public void TryUnlock()
    {
        if (Global_Upgrade_Manager.UpgradesStatus[Need])        
            UnlockButton();
    }
    public void UnlockButton()
    {
        img.color= Color.white;
        btnRef.interactable = true;
    }
    public void LockButton()
    {
        img.color= Color.gray;
        btnRef.interactable = false;
        
    }
}
