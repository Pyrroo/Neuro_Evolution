using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Build_Manager : MonoBehaviour
{
    public Build_Class[] Builds = new Build_Class[7];
    public static Build_Class[] staticBuilds = new Build_Class[10];

    


    private void Start()
    {
        for (int i= 0; i < 10; i++)
        {
            staticBuilds[i] = Builds[i];
        }
    }   

    public void BuyBuild(int i)
    {
        if (Neuro.TryToWriteOffScore(staticBuilds[i].Cost))
        {
            staticBuilds[i].Cost *= 1.15f;
            staticBuilds[i].Amount++;
            Build_chain.UpdateBuildValue();
            Neuro.UpdateSPS();            
        }
    }



}
