using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public MusicSwitcher musicSwitcher;
    void Start()
    {

    }

    public void OpenScene()
    {
        SceneManager.LoadScene("City 1");

        if(musicSwitcher)
        {
            musicSwitcher.UpdateMusic(MusicState.GameOne);
        }
    }
}