using UnityEngine;

public class HeartRemoval : MonoBehaviour
{
    public GameObject deadHeart;

    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (deadHeart.activeSelf)
        {
            playerAnimator.SetTrigger("Removal");
        }
    }
}