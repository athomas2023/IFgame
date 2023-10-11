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

    [Header("Choices")]
    public GameObject ButtonManager;

    [Header("Next Section")]
    public GameObject TextManager;


    private bool InDialog ;

    



    #endregion

    void Start()
    {
        DisplayCurrentEntry();
        ButtonManager.SetActive(false);
        InDialog = true;
    }

    void Awake()
    {
        InDialog = true;
    }

    void Update()
    {
        // Check for spacebar input to advance to the next entry
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (InDialog == true) // Dialogue Entries
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
                ButtonManager.SetActive(true);
                InDialog = false;

            }
            }
            else
            {
                gameObject.SetActive(false);
                TextManager.SetActive(true);
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

