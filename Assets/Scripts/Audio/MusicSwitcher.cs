using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MusicState
{
    MainMenu = 0,
    GameOne = 1,
    GameTwo = 2
}

public class MusicSwitcher : MonoBehaviour
{

    private MusicController theMC;

    public int newTrack;

    //public MusicState musicState;

    public bool switchOnStart;

    // Start is called before the first frame update
    void Start()
    {
        theMC = FindObjectOfType<MusicController>();
        UpdateMusic(MusicState.MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            theMC.SwitchTrack(newTrack);
            gameObject.SetActive(false);
        }
    }

    public void UpdateMusic(MusicState musicState)
    {
        if (switchOnStart)
        {
            switch (musicState)
            {
                case MusicState.MainMenu:
                    theMC.SwitchTrack(1);
                    break;
                case MusicState.GameOne:
                    theMC.SwitchTrack(0);
                    break;
                case MusicState.GameTwo:
                    theMC.SwitchTrack(2);
                    break;
            }

            gameObject.SetActive(false);
        }
    }
}
