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
}
