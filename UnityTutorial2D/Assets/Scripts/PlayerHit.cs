using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hittable"))
        {
            other.GetComponent<PotAnimator>().Break();
        }
    }
}
