using System;
using UnityEngine;
[Serializable]
public class Phase
{
    public string Description;
    public string Test_Subject;
    public float Test_Cost;
    public float Test_Time;
    public float Difficulty_Modifier;
    public int Phase_number;
    public bool completed = false;


}
