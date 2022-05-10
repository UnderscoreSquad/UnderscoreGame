using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform cattoTransform;
    public Vector3 cattoFirstPosition;

    private void Start()
    {
        cattoFirstPosition = cattoTransform.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D character)
    {
        character.transform.position = cattoFirstPosition;
    }
}
