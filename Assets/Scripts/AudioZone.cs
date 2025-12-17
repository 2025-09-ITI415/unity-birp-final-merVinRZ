using UnityEngine;

public class AudioZone : MonoBehaviour
{
    public AudioSource playThis;
    public AudioSource[] stopThese;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (stopThese != null)
        {
            foreach (var s in stopThese)
            {
                if (s != null && s.isPlaying) s.Stop();
            }
        }
        if (playThis != null && !playThis.isPlaying) playThis.Play();
    }
}