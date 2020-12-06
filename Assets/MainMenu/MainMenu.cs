using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        // LoadScene.Load(LoadScene.Scene.Dialogue);
    }

    public void onPlayButtonClicked() {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
