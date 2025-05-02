using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !audioSource.isPlaying)
                {
            audioSource.Play();
        }
    }
}
