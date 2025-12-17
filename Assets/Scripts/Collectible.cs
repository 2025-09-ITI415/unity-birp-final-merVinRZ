using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioClip pickupSfx;
    public float pickupVolume = 0.8f;

    public ParticleSystem pickupVfx;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (pickupVfx != null)
        {
            var vfx = Instantiate(pickupVfx, transform.position, Quaternion.identity);
            Destroy(vfx.gameObject, vfx.main.duration + vfx.main.startLifetime.constantMax);
        }
        if (pickupSfx != null)
            AudioSource.PlayClipAtPoint(pickupSfx, transform.position, pickupVolume);

        GameManager.instance.Collect();
        Destroy(gameObject);
    }
}
