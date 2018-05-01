using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public void LevelLoad (int level) {
        StartCoroutine(LoadAsync(level));
    }

    IEnumerator LoadAsync(int level)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(level);

        while(!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null; //waits for the next frame before looping again
        }

    }

}
