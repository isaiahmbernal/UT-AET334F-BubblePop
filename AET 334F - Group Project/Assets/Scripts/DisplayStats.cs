using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour
{
    // The stats panel that will display the overall stats

    [SerializeField] private GameObject statsPanel;

    // All text that will be used to display the stats

    // Text for single player portion of stats panel

    [SerializeField] private Text SP_healthLost;        
    [SerializeField] private Text SP_bubblePoped;
    [SerializeField] private Text SP_longestStreak;
    [SerializeField] private Text SP_songsCompleted;
    [SerializeField] private Text SP_totalScore;

    // Text for Multiplayer portion of stats panel

    // Player 1 stats text

    [SerializeField] private Text MP_healthLostP1;        
    [SerializeField] private Text MP_bubblePopedP1;
    [SerializeField] private Text MP_longestStreakP1;
    [SerializeField] private Text MP_songsCompletedP1;
    [SerializeField] private Text MP_totalScoreP1;

    // Player 2 stats text

    [SerializeField] private Text MP_healthLostP2;        
    [SerializeField] private Text MP_bubblePopedP2;
    [SerializeField] private Text MP_longestStreakP2;
    [SerializeField] private Text MP_songsCompletedP2;
    [SerializeField] private Text MP_totalScoreP2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            AccessStatsPanel();
        }

        // check to see if the single player text needs to be updated every frame

        SP_bubblePoped.text = "Bubbles Poped: " + StatsManager.SP_bubblesPoped;
        SP_longestStreak.text = "Longest Streak: " + StatsManager.SP_longestStreak;
        SP_totalScore.text = "Total Score: " + StatsManager.SP_totalScore;
        SP_songsCompleted.text = "Songs Completed: " + StatsManager.SP_SongsCompleted;
        SP_healthLost.text = "Health Lost: " + StatsManager.SP_healthLost.ToString("F1");

        // check to see if the multiplayer player 1 text needs to be updated every frame

        MP_bubblePopedP1.text = "Bubbles Poped: " + StatsManager.MP_bubblesPopedP1;
        MP_longestStreakP1.text = "Longest Streak: " + StatsManager.MP_longestStreakP1;
        MP_totalScoreP1.text = "Total Score: " + StatsManager.MP_totalScoreP1;
        MP_songsCompletedP1.text = "Songs Completed: " + StatsManager.MP_SongsCompletedP1;
        MP_healthLostP1.text = "Health Lost: " + StatsManager.MP_healthLostP1.ToString("F1");

        // check to see if the multiplayer player 2 text needs to be updated every frame

        MP_bubblePopedP2.text = "Bubbles Poped: " + StatsManager.MP_bubblesPopedP2;
        MP_longestStreakP2.text = "Longest Streak: " + StatsManager.MP_longestStreakP2;
        MP_totalScoreP2.text = "Total Score: " + StatsManager.MP_totalScoreP2;
        MP_songsCompletedP2.text = "Songs Completed: " + StatsManager.MP_SongsCompletedP2;
        MP_healthLostP2.text = "Health Lost: " + StatsManager.MP_healthLostP2.ToString("F1");
    }

    // Function that either turns on or off the stats panel depending on its current
    // state

    private void AccessStatsPanel()
    {
        bool isActive = statsPanel.activeSelf;
        statsPanel.SetActive(!isActive);
    }
}
