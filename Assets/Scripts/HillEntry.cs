using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
  public Collider2D[] hillColliders;
  public Collider2D[] boundaryColliders;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            foreach(Collider2D hill in hillColliders)
            {
                hill.enabled = false;
            }
            foreach(Collider2D boundary in boundaryColliders)
            {
                boundary.enabled = true;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
        }
    }
}
