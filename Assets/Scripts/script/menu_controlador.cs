using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controlador : MonoBehaviour
{
 public void PlayGame (int NumEscena)
    {
        SceneManager.LoadScene(NumEscena);
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
