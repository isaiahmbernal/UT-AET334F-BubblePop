using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    // variables to keep track of changing in-game stats

    // keep track of single player stats
    public static float SP_healthLost;
    public static int SP_bubblesPoped;
    public static int SP_SongsCompleted;
    public static int SP_longestStreak;
    public static int SP_totalScore;

    // keep track of multiplayer Player 1 stats
    public static float MP_healthLostP1;
    public static int MP_bubblesPopedP1;
    public static int MP_SongsCompletedP1;
    public static int MP_longestStreakP1;
    public static int MP_totalScoreP1;

    // keep track of multiplayer Player 2 stats
    public static float MP_healthLostP2;
    public static int MP_bubblesPopedP2;
    public static int MP_SongsCompletedP2;
    public static int MP_longestStreakP2;
    public static int MP_totalScoreP2;


    [SerializeField] Input_Gameplay singlePlayer;
    [SerializeField] Input_Gameplay multiplayerP1;
    [SerializeField] Input_Gameplay multiplayerP2;

    // Start is called before the first frame update
    void Start()
    {
        singlePlayer.ConnectToManager(this);
        multiplayerP1.ConnectToManager(this);
        multiplayerP2.ConnectToManager(this);
    }
    
    public void changeTotalHPLost( float lostHP )
    {
        SP_healthLost += lostHP;
    }

    public void changePopTotal( int Pop )
    {
        SP_bubblesPoped += Pop;
    }

    public void changeCompletedSongs()
    {
        int num = 1;
        SP_SongsCompleted += num;
    }

    public void changeLongestStreak( int streak )
    {
        SP_longestStreak = streak;
    }

    public void changeTotalScore( int score )
    {
        SP_totalScore += score;
    }

    public void changeTotalHPLostMP1( float lostHP )
    {
        MP_healthLostP1 += lostHP;
    }

    public void changePopTotalMP1( int Pop )
    {
        MP_bubblesPopedP1 += Pop;
    }

    public void changeCompletedSongsMP1()
    {
        int num = 1;
        MP_SongsCompletedP1 += num;
    }

    public void changeLongestStreakMP1( int streak )
    {
        MP_longestStreakP1 = streak;
    }

    public void changeTotalScoreMP1( int score )
    {
        MP_totalScoreP1 += score;
    }

    public void changeTotalHPLostMP2( float lostHP )
    {
        MP_healthLostP2 += lostHP;
    }

    public void changePopTotalMP2( int Pop )
    {
        MP_bubblesPopedP2 += Pop;
    }

    public void changeCompletedSongsMP2()
    {
        int num = 1;
        MP_SongsCompletedP2 += num;
    }

    public void changeLongestStreakMP2( int streak )
    {
        MP_longestStreakP2 = streak;
    }

    public void changeTotalScoreMP2( int score )
    {
        MP_totalScoreP2 += score;
    }
}
