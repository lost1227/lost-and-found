using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScript : MonoBehaviour
{
    public void doLoadNextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene == SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("LAST SCENE!!");
            nextScene = 0;
        }
        SceneManager.LoadScene(nextScene);
    }
}
