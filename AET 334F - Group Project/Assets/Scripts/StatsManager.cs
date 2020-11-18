using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    private int healthLost;
    private int bubblesPoped;
    private int levelsCompleted;
    private int longestStreak;
    private int totalScore;

    private Input_Gameplay component;

    // Start is called before the first frame update
    void Start()
    {
        component.ConnectToManager(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void changeTotalHPLost( int lostHP )
    {
        healthLost += lostHP;
    }

    public void changePopTotal( int Pop )
    {
        bubblesPoped += Pop;
    }

    public void changeCompletedLvls( int num )
    {
        num = 1;
        levelsCompleted += num;
    }

    public void changeLongestStreak( int streak )
    {
        longestStreak = streak;
    }

    public void changeTotalScore( int score )
    {
        totalScore += score;
    }
}
