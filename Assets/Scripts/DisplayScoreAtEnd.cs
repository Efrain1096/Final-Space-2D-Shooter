using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreAtEnd : MonoBehaviour
{
   


    public Text totalEnemyKills;
    
    void Update()
    {        
        totalEnemyKills.text = "Total Enemies Killed: " + GlobalControl.Instance.totalEnemyKills;
    }


}
