using UnityEngine;


public class UI_Swap : MonoBehaviour
{
    public Canvas Main_UI, General_Menu;

    private void Start()
    {
        General_Menu.gameObject.SetActive(false);
    }
    public void SwapToGeneral()
    {
        General_Menu.gameObject.SetActive(true);
        Main_UI.gameObject.SetActive(false);
        //Time.timeScale = 0;
    }
    public void SwapToMain()
    {
        General_Menu.gameObject.SetActive(false);
        Main_UI.gameObject.SetActive(true);
       // Time.timeScale = 1;
    }
}
