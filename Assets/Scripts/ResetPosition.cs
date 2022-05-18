using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 playerFirstPosition;

    public GameObject fpsText;
    public GameObject objectText;
    public GameObject heartDisplay;
    public GameObject liveHeartOne;
    public GameObject liveHeartTwo;
    public GameObject liveHeartThree;
    public GameObject deadHeartOne;
    public GameObject deadHeartTwo;
    public GameObject deadHeartThree;
    public GameObject deadScreen;
    public GameObject mainMusic;
    public GameObject deadMusic;

    private void Start()
    {
        playerFirstPosition = playerTransform.transform.position;

        liveHeartOne.SetActive(true);
        liveHeartTwo.SetActive(true);
        liveHeartThree.SetActive(true);
        deadHeartOne.SetActive(false);
        deadHeartTwo.SetActive(false);
        deadHeartThree.SetActive(false);
        deadScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D character)
    {
        if (liveHeartOne.activeSelf)
        {
            liveHeartOne.SetActive(false);
            deadHeartOne.SetActive(true);
            character.transform.position = playerFirstPosition;
        }

        else if (!liveHeartOne.activeSelf)
        {
            if (liveHeartTwo.activeSelf)
            {
                liveHeartTwo.SetActive(false);
                deadHeartTwo.SetActive(true);
                character.transform.position = playerFirstPosition;
            }

            else if (!liveHeartTwo.activeSelf)
            {
                if (liveHeartThree.activeSelf)
                {
                    liveHeartThree.SetActive(false);
                    deadHeartThree.SetActive(true);
                    deadScreen.SetActive(true);

                    Time.timeScale = 0f;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    fpsText.SetActive(false);
                    objectText.SetActive(false);
                    heartDisplay.transform.position = new Vector2(1000f, 1000f);
                    mainMusic.SetActive(false);
                    deadMusic.SetActive(true);
                }
            }
        }
    }
}
