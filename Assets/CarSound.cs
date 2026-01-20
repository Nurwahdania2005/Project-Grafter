using UnityEngine;

public class CarSound : MonoBehaviour
{
    public AudioSource carAudio;

    public void PlaySound()
    {
        carAudio.Play();
    }

    public void StopSound()
    {
        carAudio.Stop();
    }
}
