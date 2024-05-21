using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDDOL : MonoBehaviour
{

    private static bool audioManExists;

    // Start is called before the first frame update
    void Start()
    {
        if (!audioManExists)
        {
            audioManExists = true;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
