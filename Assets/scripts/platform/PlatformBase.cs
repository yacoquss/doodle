using Unity.VisualScripting;
using UnityEngine;


public class PlatformBase : MonoBehaviour, IPlatform
{
    [SerializeField] private float _force;
    public void push(Player player)
    {
        player.gameObject.TryGetComponent<Rigidbody2D>(out var rigidbody);
        rigidbody?.AddForce(player.transform.up * _force, ForceMode2D.Impulse);
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            if(collision.relativeVelocity.y < 0) push(player);
            
        }
    }
}