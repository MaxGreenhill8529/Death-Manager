using System.Collections;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    public DestroyType destroyType;
    [SerializeField] private float delay;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(destroyType == DestroyType.CollisionEnter2D)
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        if(destroyType == DestroyType.OnBecameInvisible)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Start()
    {
        if(destroyTypev == DestroyType.Delay)
        yield return new WaitForSeconds(delay);
        Destroy(gameDestroy);
    }
}

public enum DestroyType
{
    Delay,
    CollisionEnter2D,
    OnBecameInvisible
}
