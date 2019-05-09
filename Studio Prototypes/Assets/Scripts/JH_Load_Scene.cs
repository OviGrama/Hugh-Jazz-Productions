using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JH_Load_Scene : MonoBehaviour
{
    public string st_loadScene;
    public Text tx_loading;
    private AsyncOperation asyncLoad;
    private bool bl_isLoading;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    

    IEnumerator LoadScene()
    {
        asyncLoad = SceneManager.LoadSceneAsync(st_loadScene);
        bl_isLoading = true;

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    private void Update()
    {
        if (bl_isLoading) tx_loading.text = "Loading: " + (Mathf.RoundToInt(asyncLoad.progress * 100)).ToString() + "%";
    }
}
