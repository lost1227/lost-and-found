using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoghouseScript : MonoBehaviour
{
    private LoaderScript loader;
    // Start is called before the first frame update
    void Start()
    {
        loader = FindObjectOfType<LoaderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        loader.doLoadNextLevel();
    }

}
