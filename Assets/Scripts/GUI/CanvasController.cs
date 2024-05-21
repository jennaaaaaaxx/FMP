using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public static bool canvasExists;

    // Start is called before the first frame update
    void Start()
    {
        if(!canvasExists)
        {
            canvasExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
