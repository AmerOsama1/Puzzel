using UnityEngine;
using UnityEngine.InputSystem;

public class changePosition : MonoBehaviour
{
    public Transform emptyPosition;
    public LayerMask mask;
    public float minDistance = 2f;
    public Camera cc;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (cc == null) return;

            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector2 worldPoint = cc.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0f));

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero, Mathf.Infinity, mask);

            if (hit.collider != null)
            {
                float distance = Vector2.Distance(emptyPosition.position, hit.transform.position);

                if (distance < minDistance && distance > Mathf.Epsilon)
                {
                    Debug.Log("Swapping with: " + hit.transform.name);

                    Vector3 temp = hit.transform.position;
                    hit.transform.position = emptyPosition.position;
                    emptyPosition.position = temp;
                }
            }
        }
    }
}
