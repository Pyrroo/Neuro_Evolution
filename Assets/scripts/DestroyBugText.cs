using UnityEngine;

public class DestroyBugText : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�� ��� ƨ����");
        collision.gameObject.SetActive(false);
    }
}
