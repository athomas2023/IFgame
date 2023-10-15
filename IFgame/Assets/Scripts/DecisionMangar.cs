using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DecisionMangar : MonoBehaviour
{
     
    public TextMeshProUGUI ChoiceMeter;

    private float choiceVar = 0f;
    private string choiceDisplay;

    public TextMeshProUGUI OverWriteText;

      [Header("Choices")]
    public string GreatEnding = "";
    public float GreatPoints = 1.0f;
    public string GoodEnding = "";
    public float GoodPoints = .5f;
    public string BadEnding = "";
    public float Badpoints = -1.0f;

    public GameObject Buttonrow;

    [Header("Health Points")]
    public int IncreaseHealth = 1;
    public int Decreasehealth =-1;
    public int NaturalHealth = 0; 

     private PlayerHealth playerHealthScript; // Reference to the PlayerHealth script

    
   
    
    private void Start()
    {
      // Load choiceVar from PlayerPrefs if it exists, otherwise, initialize it to 0.
        if (PlayerPrefs.HasKey("ChoiceVar"))
        {
            choiceVar = PlayerPrefs.GetFloat("ChoiceVar");
        }
        else
        {
            choiceVar = 0.0f;
        }
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        // Find the PlayerHealth script globally
        playerHealthScript = FindObjectOfType<PlayerHealth>();

    }


  private void Update()
    {
        // Check for the Escape key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Reset PlayerPrefs
            PlayerPrefs.DeleteKey("ChoiceVar");
            PlayerPrefs.Save();

            // Reset the choiceVar and update the display
            choiceVar = 0.0f;
            // Quit the application or stop play mode in the editor
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Close play mode in the editor
            #else
            Application.Quit(); // Quit the application
            #endif

           
        }
    }

   public void Great()
   {
        choiceVar += GreatPoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GreatEnding;

         // Save choiceVar
    PlayerPrefs.SetFloat("ChoiceVar", choiceVar);
    PlayerPrefs.Save();
    playerHealthScript.AdjustPlayerHealth(IncreaseHealth);

     Buttonrow.SetActive(false);

     

   }

   public void Good()
   {

        choiceVar += GoodPoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GoodEnding;

         // Save choiceVar
    PlayerPrefs.SetFloat("ChoiceVar", choiceVar);
    PlayerPrefs.Save();

    playerHealthScript.AdjustPlayerHealth(NaturalHealth);

    Buttonrow.SetActive(false);
   }

   public void Bad()
   {
        choiceVar -= Badpoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = BadEnding;

         // Save choiceVar
    PlayerPrefs.SetFloat("ChoiceVar", choiceVar);
    PlayerPrefs.Save();

    playerHealthScript.AdjustPlayerHealth(Decreasehealth);

    Buttonrow.SetActive(false);

   }
}
