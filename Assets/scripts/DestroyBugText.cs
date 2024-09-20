using UnityEngine;

public class DestroyBugText : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("‰¿ ›“Œ ∆®—“ Œ");
        collision.gameObject.SetActive(false);
    }
}
