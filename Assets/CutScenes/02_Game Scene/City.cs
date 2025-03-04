using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class City : MonoBehaviour
{
    public PlayableDirector[] timelines;
    private int currentIndex = 0;

    void Start()
    {
        if (timelines.Length > 0)
        {
            PlayNextTimeline();
        }
    }

    void PlayNextTimeline()
    {
        if (currentIndex < timelines.Length)
        {
            timelines[currentIndex].gameObject.SetActive(true);
            timelines[currentIndex].Play();
            timelines[currentIndex].stopped += OnTimelineStopped;
        }
        else
        {
            LoadingHouseScene();
        }
    }

    void OnTimelineStopped(PlayableDirector director)
    {
        director.stopped -= OnTimelineStopped;
        director.gameObject.SetActive(false);
        currentIndex++;
        PlayNextTimeline();
    }

    public void LoadingHouseScene()
    {
        Debug.Log("Loading House");
        SceneManager.LoadScene("House");
    }
}