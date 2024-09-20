using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using System.Collections;
using UnityEngine.Rendering.Universal;

public class Score_Spawn_SCR : MonoBehaviour
{
    public GameObject scorePrefab;
    private TextMeshProUGUI textPrefab;
    public Transform canvasTransform;

    bool eventActive;

    public Canvas canvas; // —сылка на канвас   
    public RectTransform canvasRectTransform; // RectTransform канваса

    private bool isCooldown;

    private void Start()
    {
        scorePrefab.SetActive(true);
        

    }

    public void ClickToButton()
    {
        if (!isCooldown)
        {
            ShowClickScore();
            StartCoroutine(CooldownRoutine());
        }
    }

    IEnumerator CooldownRoutine()
    {
        isCooldown = true;
        yield return new WaitForSeconds(0.08f);
        isCooldown = false;
    }

    public void ShowClickScore()
    {
        if (Global_Upgrade_Manager.UpgradesStatus["Second_AC"])
        {
            if (Random.value < DoubleClick_Upgrade.quadrupleChance)
            {
                
                Neuro.QuadroClickToNeuro();
                ShowScoreFromClick(((1 * Neuro.ClickMultiplaer)+ (1 * Neuro.ClickMultiplaer)+ (1 * Neuro.ClickMultiplaer)+ (1 * Neuro.ClickMultiplaer)).ToString());
            }
            else
            {
                if(Random.value < DoubleClick_Upgrade.TripleChance)
                {
                    ShowScoreFromClick(((1 * Neuro.ClickMultiplaer) + (1 * Neuro.ClickMultiplaer) + (1 * Neuro.ClickMultiplaer)).ToString());
                    Neuro.TripleClickToNeuro();
                }
                else
                {
                    if (Random.value < DoubleClick_Upgrade.DoubleChance)
                    {
                        ShowScoreFromClick(((1 * Neuro.ClickMultiplaer) + (1 * Neuro.ClickMultiplaer)).ToString());
                        Neuro.DoubleClickToNeuro();
                    }
                    else
                    {
                        ShowScoreFromClick((1 * Neuro.ClickMultiplaer).ToString());
                        Neuro.ClickToNeuro();
                    }

                }
                
            }
        }
        else
        {
            ShowScoreFromClick((1 * Neuro.ClickMultiplaer).ToString());
            Neuro.ClickToNeuro();
        }
    }


    private void ShowScoreFromClick(string score)
    {
        Vector2 mousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, canvas.worldCamera, out mousePosition);
        Vector3 localPosition = new Vector3(mousePosition.x + 90f, mousePosition.y + 15, 0f);
        GameObject scoreText = ObjectPoolController.CreateGameObject(scorePrefab, canvasTransform, localPosition);
        scoreText.GetComponent<TextMeshProUGUI>().text = score;
    }


}
