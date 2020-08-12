using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTransition : MonoBehaviour
{
    // Purpose of this script is to have music not restart its loop when changing from scene to scene.

    private static AudioTransition instance;

    private void Awake()
    {

        // We only want one instance of the music to be playing and saved between scenes to allow for continuity between changes.

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
