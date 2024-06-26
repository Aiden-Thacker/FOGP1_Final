using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    public LoseMenu loseMenu; // For the player if the Blue side Loses 
    public WinMenu winMenu; //For the player if the Blue side Wins

    // Lists to store objects with red and blue tags
    private List<GameObject> redObjects = new List<GameObject>();
    private List<GameObject> blueObjects = new List<GameObject>();
    
    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        // Find all objects with the "Red" tag and add them to the redObjects list
        GameObject[] redObjectsArray = GameObject.FindGameObjectsWithTag("Red");
        redObjects.AddRange(redObjectsArray);

        // Find all objects with the "Blue" tag and add them to the blueObjects list
        GameObject[] blueObjectsArray = GameObject.FindGameObjectsWithTag("Blue");
        blueObjects.AddRange(blueObjectsArray);
    }

    // Function to add object to corresponding list based on tag
    public void AddObjectToList(GameObject obj)
    {
        if (obj.CompareTag("Red"))
        {
            redObjects.Add(obj);
        }
        else if (obj.CompareTag("Blue"))
        {
            blueObjects.Add(obj);
        }
    }

    // Function to remove object from corresponding list based on tag
    public void RemoveObjectFromList(GameObject obj)
    {
        if (obj.CompareTag("Red"))
        {
            redObjects.Remove(obj);
            CheckWinCondition();
        }
        else if (obj.CompareTag("Blue"))
        {
            blueObjects.Remove(obj);
            CheckLoseCondition();
        }
    }

    // Function to check lose condition
    private void CheckLoseCondition()
    {
        if (blueObjects.Count == 0)
        {
            Debug.Log("Your Team Lost");
            loseMenu.Lose();
        }
    }

    private void CheckWinCondition()
    {
        if (redObjects.Count == 0)
        {
            Debug.Log("Your Team Won");
            winMenu.Win();
        }
    }

    
}
