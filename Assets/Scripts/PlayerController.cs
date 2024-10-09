using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] characters; // Array to hold your character GameObjects
    private int currentCharacterIndex = 0; // Index of the currently active character

    void Start()
    {
        // Initialize with the first character
        ToggleCharacter(0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Detect mouse click
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked object is a player character
                if (hit.collider.CompareTag("Player"))
                {
                    // Get the index of the next character
                    currentCharacterIndex = (currentCharacterIndex + 1) % characters.Length;

                    // Toggle the new character
                    ToggleCharacter(currentCharacterIndex);
                }
            }
        }
    }

    void ToggleCharacter(int index)
    {
        // Disable all characters
        foreach (GameObject character in characters)
        {
            character.SetActive(false);
        }

        // Enable the selected character
        characters[index].SetActive(true);
    }
}