using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {
    public VideoPlayer vp;
    void Update() {
        if (Input.GetKeyDown(KeyCode.V)) vp.Play();
    }
}