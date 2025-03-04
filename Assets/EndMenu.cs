using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadingStartScene()
    {
        Debug.Log("Loading Main Menu");
        SceneManager.LoadScene("Main Menu");
    }
 
    public void ExitApplication()
    {
        Debug.Log("Exiting Application");
        Application.Quit();
    }
}