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
    public float GreatPoints = 1f;
    public string GoodEnding = "";
    public float GoodPoints = .5f;
    public string BadEnding = "";
    public float Badpoints = -1f;

    
   
    
    private void Start()
    {
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

    }
   public void Great()
   {
        choiceVar += GreatPoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GreatEnding;

   }

   public void Good()
   {

        choiceVar += GoodPoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GoodEnding;
   }

   public void Bad()
   {
        choiceVar -= Badpoints;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = BadEnding;
   }
}
