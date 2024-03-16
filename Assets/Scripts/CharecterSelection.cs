using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    // Array to store character sprites or images
    public Sprite[] characterSprites;

    // Index of the currently selected character
    private int currentCharacterIndex = 0;

    // Reference to the UI image displaying the character
    public Image characterDisplayImage;

    // Function to initialize the character selection UI
    void Start()
    {
        // Set the initial character display
        UpdateCharacterDisplay();
    }

    // Function to switch to the next character
    public void NextCharacter()
    {
        // Increment the character index
        currentCharacterIndex++;

        // Wrap around to the first character if at the end of the array
        if (currentCharacterIndex >= characterSprites.Length)
        {
            currentCharacterIndex = 0;
        }

        // Update the character display
        UpdateCharacterDisplay();
    }

    // Function to switch to the previous character
    public void PreviousCharacter()
    {
        // Decrement the character index
        currentCharacterIndex--;

        // Wrap around to the last character if at the beginning of the array
        if (currentCharacterIndex < 0)
        {
            currentCharacterIndex = characterSprites.Length - 1;
        }

        // Update the character display
        UpdateCharacterDisplay();
    }

    // Function to update the character display image
    void UpdateCharacterDisplay()
    {
        // Set the image sprite to the sprite of the current character
        characterDisplayImage.sprite = characterSprites[currentCharacterIndex];
    }

    // Function to confirm the selected character (can be called when "Confirm" button is pressed)
    public void ConfirmCharacter()
    {
        // Optionally, you can save the selected character index or perform any other action here
        Debug.Log("Selected character: " + currentCharacterIndex);
    }
}
