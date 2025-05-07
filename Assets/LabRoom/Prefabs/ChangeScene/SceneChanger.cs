using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneNameToLoad;

    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneNameToLoad))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(sceneNameToLoad);
            Debug.Log("Open " + sceneNameToLoad);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            LoadScene();
        }
    }
}
