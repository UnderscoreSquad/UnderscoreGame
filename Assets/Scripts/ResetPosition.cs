using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 playerFirstPosition;

    public GameObject LiveHeartOne;
    public GameObject LiveHeartTwo;
    public GameObject LiveHeartThree;
    public GameObject DeadHeartOne;
    public GameObject DeadHeartTwo;
    public GameObject DeadHeartThree;
    public GameObject DeadScreen;
    public GameObject MainMusic;
    public GameObject DeadMusic;

    private void Start()
    {
        playerFirstPosition = playerTransform.transform.position;

        LiveHeartOne.SetActive(true);
        LiveHeartTwo.SetActive(true);
        LiveHeartThree.SetActive(true);
        DeadHeartOne.SetActive(false);
        DeadHeartTwo.SetActive(false);
        DeadHeartThree.SetActive(false);
        DeadScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D character)
    {
        if (LiveHeartOne.activeSelf)
        {
            LiveHeartOne.SetActive(false);
            DeadHeartOne.SetActive(true);
        }

        else if (!LiveHeartOne.activeSelf)
        {
            if (LiveHeartTwo.activeSelf)
            {
                LiveHeartTwo.SetActive(false);
                DeadHeartTwo.SetActive(true);
            }

            else if (!LiveHeartTwo.activeSelf)
            {
                if (LiveHeartThree.activeSelf)
                {
                    LiveHeartThree.SetActive(false);
                    DeadHeartThree.SetActive(true);
                    DeadScreen.SetActive(true);

                    Time.timeScale = 0f;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    MainMusic.SetActive(false);
                    DeadMusic.SetActive(true);
                }
            }
        }

        character.transform.position = playerFirstPosition;
    }
}
