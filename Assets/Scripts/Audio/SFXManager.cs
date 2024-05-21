using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{

    public AudioSource doorOpen;
    public AudioSource doorClose;
    public AudioSource itemPickup1;
    public AudioSource itemPickup2;

    private static bool sfxManExists;

    // Start is called before the first frame update
    void Start()
    {
        if(!sfxManExists)
        {
            sfxManExists = true;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
