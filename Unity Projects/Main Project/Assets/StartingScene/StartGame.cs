using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartGame : MonoBehaviour
{
    public GameObject cam;
    public GameObject button;
    public GameObject logo;

    public void PlayGame()
    {
        cam.GetComponent<VideoPlayer>().playbackSpeed = 1;
        button.SetActive(false);
        logo.SetActive(false);
    }
}
