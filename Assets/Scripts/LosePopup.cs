using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePopup : MonoBehaviour
{
    public void PlayAgain(int level) 
    {
        SceneManager.LoadScene("Level"+ level);
    }

    public void GoBack()
    {
        SceneManager.LoadScene("StartingScene");
    }
}
