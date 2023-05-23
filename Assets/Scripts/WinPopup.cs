using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPopup : MonoBehaviour
{

   
    
    public void OpenLevel(int level)
    {
        
        SceneManager.LoadScene("Level" + level);
        
    }


    public void GoBack()
    {
        SceneManager.LoadScene("StartingScene");
    }

   
}
