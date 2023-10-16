using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    private DecisionMangar decisionManager;
    private PlayerHealth playerHealthScript; // Reference to the PlayerHealth script

 private void Start()
    {
       playerHealthScript = FindObjectOfType<PlayerHealth>();

        
        decisionManager = FindObjectOfType<DecisionMangar>();
       

    }




    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadAct2()
    {
        SceneManager.LoadScene(2);
    }

        public void LoadAct3()
    {
       // SceneManager.LoadScene(4);
    }


         public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }

         public void Gameover()
    {
        decisionManager.ResetPlayerPrefs();
        playerHealthScript.ResetPlayerPrefs();
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {

        
        Application.Quit();
    }
}
