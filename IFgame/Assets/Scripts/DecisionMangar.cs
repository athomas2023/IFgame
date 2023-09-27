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


    public string GreatEnding = "";
    public string GoodEnding = "";
    public string BadEnding = "";
    
    private void Start()
    {
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

    }
   public void Great(string GreatEnding)
   {
        choiceVar += 1f;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GreatEnding;

   }

   public void Good()
   {

        choiceVar += 0.5f;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = GoodEnding;
   }

   public void Bad()
   {
        choiceVar -= 1f;
        choiceDisplay = choiceVar.ToString();
        ChoiceMeter.text = choiceDisplay;

        OverWriteText.text = BadEnding;
   }
}
