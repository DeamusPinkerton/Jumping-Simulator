using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaIniciar()
    {
        SceneManager.LoadScene("Endless Runner");
    }
    public void EscenaInstrucciones()
    {
        SceneManager.LoadScene("Settings");
    }
    public void EscenaCreditos()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
