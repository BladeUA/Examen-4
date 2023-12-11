using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneControl : MonoBehaviour 
{
    public string levelToLoad;
    public void Load()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
