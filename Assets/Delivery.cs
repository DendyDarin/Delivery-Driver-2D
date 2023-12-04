using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool isPackageHasPickedUp;
    [SerializeField] float delayBeforeDestroy = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // Debug.Log("nabrak");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !isPackageHasPickedUp)
        {
            spriteRenderer.color = hasPackageColor;
            isPackageHasPickedUp = true;
            Destroy(other.gameObject, delayBeforeDestroy);
        }
        
        if(other.tag == "Customer" && isPackageHasPickedUp)
        {
            spriteRenderer.color = noPackageColor;
            isPackageHasPickedUp = false;
        }
    }
}
