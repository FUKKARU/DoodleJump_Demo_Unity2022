using UnityEngine;

public class FloorBreakable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") && collision.transform.position.y > transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
