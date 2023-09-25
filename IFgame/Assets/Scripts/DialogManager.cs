using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    #region Fields
    public TextMeshProUGUI targetOverwriteText;
    public string[] textEntries;
    public int maxEntries = 5; // Change this to your desired maximum number of entries

    private int currentEntryIndex = 0;
    #endregion 


    #region  

    



    #endregion

    void Start()
    {
        DisplayCurrentEntry();
    }

    void Update()
    {
        // Check for spacebar input to advance to the next entry
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentEntryIndex++;

            // Check if there are more entries to display
            if (currentEntryIndex < textEntries.Length)
            {
                DisplayCurrentEntry();
            }
            else
            {
                Debug.Log("No more entries");
            }
        }
    }

    void DisplayCurrentEntry()
    {
        if (currentEntryIndex < textEntries.Length)
        {
            // Set the TextMeshProUGUI text to the current entry
            if (targetOverwriteText != null)
            {
                targetOverwriteText.text = textEntries[currentEntryIndex];
            }
        }
    }
}

