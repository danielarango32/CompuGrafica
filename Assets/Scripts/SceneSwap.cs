using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneSwap : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        SceneManager.GetActiveScene();
    }
    public void SiguienteEfecto1()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SampleScene"))
            SceneManager.LoadScene("Scenes/Explosion");
    }
    public void SiguienteEfecto2()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Explosion"))
            SceneManager.LoadScene("Scenes/Thunder");
    }
    public void SiguienteEfecto3()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Thunder"))
            SceneManager.LoadScene("Scenes/Vortex");
    }
    public void SiguienteEfecto4()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Vortex"))
            SceneManager.LoadScene("Scenes/Explosion");
    }
}