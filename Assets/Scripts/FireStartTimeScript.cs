using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FireStartTimeScript : MonoBehaviour
{
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoPlayer>().time = startTime;
    }
}
