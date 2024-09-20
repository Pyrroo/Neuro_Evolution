using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Neuro : MonoBehaviour
{
   
    static public float score = 0;
    static public float ClickMultiplaer = 1;
    static public float SPSMultiplaer = 1;
    static public float allScore=0;
    static public float ScorePerSecond=0;

    public GameObject scoreTextPrefab;
    public Transform canvasTransform;

    public GameObject floatingTextPrefab;

    public Vector3 offset = new Vector3(0, 2, 0);
    public TextMeshProUGUI Score_Banner;
    public TextMeshProUGUI ScorePerSecond_Banner;
    public void Score_Update()
     {
        Score_Banner.text = score.ToString("N0");
        ScorePerSecond_Banner.text= ScorePerSecond.ToString("N0");
     }


    public static void ClickToNeuro()
    {
        score+= 1 * ClickMultiplaer;
        allScore += 1 * ClickMultiplaer;
    }
    public static void DoubleClickToNeuro()
    {
        score += (1 * ClickMultiplaer) + (1 * ClickMultiplaer);
        allScore += (1 * ClickMultiplaer) + (1 * ClickMultiplaer);
    }    
    public static void TripleClickToNeuro()
    {
        score += (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer);
        allScore += (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer); 
    }
    public static void QuadroClickToNeuro()
    {
        score += (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer);
        allScore += (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer) + (1 * ClickMultiplaer);
    }

    public static bool TryToWriteOffScore(float score)
    {
        if (score <= Neuro.score)
        {
            Neuro.score -= score;
            return true;
        }
        else
        {
            return false;
        }        
    }
    public static void AddScore(float score)
    {
        Neuro.score += score;
        Neuro.allScore +=score;
    }

    public static void UpdateSPS()
    {
        ScorePerSecond = 0;
        for (int i = 0; i < 10; i++)
        {            
            ScorePerSecond += Build_Manager.staticBuilds[i].Amount * Build_Manager.staticBuilds[i].Value * Build_Manager.staticBuilds[i].Value_multiplaer;
            
        }
        ScorePerSecond *= SPSMultiplaer;
    }



    private void Start()
    {
        Application.targetFrameRate = 165;
    }
    private void Update()
    {
        Score_Update();
        score += ScorePerSecond * Time.deltaTime;
        allScore+= ScorePerSecond * Time.deltaTime;
    }

}
