using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioClip[] audios;
    public AudioSource audioPlayer;
    void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    public void EscenaMenuPrinc()
    {
        SceneManager.LoadScene(0);
    }

    public void EscenaIniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void EscenaInstrucciones()
    {
        SceneManager.LoadScene(2);
    }
    public void EscenaCreditos()
    {
        SceneManager.LoadScene(3);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ClipClick()
    {
        audioPlayer.clip = audios[0];
        audioPlayer.Play();

    }
}
