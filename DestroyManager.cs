using System.Collections;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    public DestroyType destroyType;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(destroyType == DestroyType.CollisionEnter2D)
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0f);
    }
}

public enum DestroyType
{
    Delay,
    CollisionEnter2D
}
