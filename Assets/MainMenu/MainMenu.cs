using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        LoadScene.Load(LoadScene.Scene.Dialogue);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
