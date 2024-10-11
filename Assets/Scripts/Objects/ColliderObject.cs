using System.Collections.Generic;
using UnityEngine;

public class ColliderObject : MonoBehaviour
{
    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>();

    protected virtual void Start()
    {
        z_Collider = GetComponent<Collider2D>();

        if (z_Collider == null)
        {
            Debug.LogError("Collider2D component is missing from this GameObject.");
        }
    }

    protected virtual void Update()
    {
        if (z_Collider == null) return;  // Avoid running the code if the collider is null

        z_Collider.OverlapCollider(z_Filter, z_CollidedObjects);
        foreach (var o in z_CollidedObjects)
        {
            OnCollided(o.gameObject);
        }
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("Collided with " + collidedObject.name);
    }
}
