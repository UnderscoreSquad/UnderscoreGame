using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 playerFirstPosition;

    private void Start()
    {
        playerFirstPosition = playerTransform.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D character)
    {
        character.transform.position = playerFirstPosition;
    }
}
