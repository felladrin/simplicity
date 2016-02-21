using UnityEngine;

public class MusicController : MonoBehaviour
{
    void Awake()
    {
        if (!GameController.musicIsPlaying)
        {
            DontDestroyOnLoad(transform.gameObject);
            AudioSource audio = gameObject.GetComponent<AudioSource>();
            audio.Play();
            GameController.musicIsPlaying = true;
        }
    }
}
