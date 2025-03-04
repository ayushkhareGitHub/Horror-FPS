using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Starting : MonoBehaviour
{
    public GameObject timelineObject;
    public PlayableDirector timeline;

    void Start()
    {
        timelineObject.SetActive(true);

        if (timelineObject != null)
        {
            PlayTimeline();
        }
    }

    public void PlayTimeline()
    {
        timeline.Play();
    }

    public void DiscoverButtonPressed()
    {
        Debug.Log("Loading City");
        SceneManager.LoadScene("City");
    }

}