using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] gameObjects;

    // Index of the currently selected game object
    private int currentIndex = 0;

   

    public void NextCharecter() {
        
        currentIndex = (currentIndex - 1 + gameObjects.Length) % gameObjects.Length;
        SelectGameObject(currentIndex);

    }


    public void PreviousCharecter() {

        currentIndex = (currentIndex + 1) % gameObjects.Length;
        SelectGameObject(currentIndex);
    }

    // Function to select the game object at the specified index
    private void SelectGameObject(int index)
    {
        // Disable all game objects
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
        }

        // Enable the selected game object
        gameObjects[index].SetActive(true);
    }
}
