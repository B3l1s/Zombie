using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scena : MonoBehaviour
{
   public void LoadScene()
    {
        SceneManager.LoadScene("Nivel");
    }
    public void Return()
    {
        SceneManager.LoadScene("Start");
    }
    public void rules()
    {
        SceneManager.LoadScene("rules");
    }

}
