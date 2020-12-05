using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    public enum Scene
    {
        Dialogue,
    }

    // Update is called once per frame
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
