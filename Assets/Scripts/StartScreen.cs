using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public AudioSource SetingsSounds;
    public void Play()
    {
        SceneManager.LoadScene("Level1"); //vkluci ja scenata GameScene
    }

    public void Quit()
    {
        EditorApplication.isPlaying = false; // isto kako da sme kliknale na play kopceto vo editorot dodeka igrata e aktivna
 
    }

    public void Setings()
    {
        SetingsSounds.Play();
    }
}
