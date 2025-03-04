using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadingStartScene()
    {
        Debug.Log("Loading Start Scene");
        SceneManager.LoadScene("Starting");
    }
}