using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_SpawnNotes : MonoBehaviour
{
    [SerializeField] private Transform arrowUpPos;
    [SerializeField] private Transform arrowDownPos;
    [SerializeField] private Transform arrowLeftPos;
    [SerializeField] private Transform arrowRightPos;
    [SerializeField] private GameObject gameplayCanvas;

    public GameObject noteUp;
    public GameObject noteDown;
    public GameObject noteLeft;
    public GameObject noteRight;

    private GameObject chosenNote;

    bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnNotes());
    }

    IEnumerator SpawnNotes()
    {
        while (isSpawning)
        {
            // Debug.Log ("Courotining");
            int whichNote = Random.Range (0, 4);
            float waitTime = Random.Range (.5f, 1f);

            switch (whichNote)
            {
                case (0):
                    chosenNote = noteUp;
                    chosenNote.transform.position = new Vector2 (arrowUpPos.transform.position.x, arrowUpPos.transform.position.y - 1000);
                    break;
                case (1):
                    chosenNote = noteDown;
                    chosenNote.transform.position = new Vector2 (arrowDownPos.transform.position.x, arrowDownPos.transform.position.y - 1000);
                    break;
                case (2):
                    chosenNote = noteLeft;
                    chosenNote.transform.position = new Vector2 (arrowLeftPos.transform.position.x, arrowLeftPos.transform.position.y - 1000);
                    break;
                case (3):
                    chosenNote = noteRight;
                    chosenNote.transform.position = new Vector2 (arrowRightPos.transform.position.x, arrowRightPos.transform.position.y - 1000);
                    break;
            }
            GameObject spawnedNote = Instantiate (chosenNote, chosenNote.transform.position, chosenNote.transform.rotation);
            spawnedNote.transform.SetParent(gameplayCanvas.transform);
            spawnedNote.AddComponent<Gameplay_MoveNote>();
            yield return new WaitForSeconds (waitTime);
        }
    }
}