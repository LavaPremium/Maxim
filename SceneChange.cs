using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        //Челик умирает(тп на начало)
        EditorSceneManager.LoadScene(sceneName);
    }
}