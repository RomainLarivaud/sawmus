using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void play()
    {
        // Application.LoadLevel( );
    }

    void showOptionsMenu()
    {
CanvasA.gameObject.SetActive(false);
CanvasB.gameObject.SetActive(true);
    }

    void hideOptionsMenu()
    {

    }

    void quit()
    {
        
    }
}
