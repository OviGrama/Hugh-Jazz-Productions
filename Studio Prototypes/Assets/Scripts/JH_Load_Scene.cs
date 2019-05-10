using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JH_Load_Scene : MonoBehaviour
{
    public string st_loadScene;
    private AsyncOperation asyncLoad;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    

    IEnumerator LoadScene()
    {
        asyncLoad = SceneManager.LoadSceneAsync(st_loadScene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
