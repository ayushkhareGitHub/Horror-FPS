using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class House : MonoBehaviour
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
            LoadingEndScene();
        }
    }

    void OnTimelineStopped(PlayableDirector director)
    {
        director.stopped -= OnTimelineStopped;
        director.gameObject.SetActive(false);
        currentIndex++;
        PlayNextTimeline();
    }

    public void LoadingEndScene()
    {
        Debug.Log("Loading End Scene");
        SceneManager.LoadScene("End Menu");
    }
}