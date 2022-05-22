using UnityEngine;

public class InstantDeath : MonoBehaviour
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
    public GameObject instantDeadHearts;
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
        instantDeadHearts.SetActive(false);
        deadScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D character)
    {
        liveHeartOne.SetActive(false);
        liveHeartTwo.SetActive(false);
        liveHeartThree.SetActive(false);
        instantDeadHearts.SetActive(true);
        deadScreen.SetActive(true);

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        fpsText.SetActive(false);
        objectText.SetActive(false);
        heartDisplay.transform.localScale = new Vector3(0f, 0f, 1f);
        mainMusic.SetActive(false);
        deadMusic.SetActive(true);
    }
}