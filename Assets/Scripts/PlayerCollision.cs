using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject controlsUI;
    public GameObject optionsUI;
    public GameObject creditsUI;
    public GameObject secretUI;
    public GameObject oobUI;
    public GameObject winUI;
    public GameObject fpsText;
    public GameObject objectText;
    public GameObject mainMusic;
    public GameObject winMusic;
    public GameObject oobMusic;
    public GameObject keyMusic;
    public GameObject secretMusic;
    public GameObject Key;
    public GameObject Reveal;
    public GameObject Secret;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            base.transform.position = new Vector3(-15.70221f, -7.5f, 0f);
        }

        if (collision.gameObject.tag == "Obstacle2")
        {
            base.transform.position = new Vector3(15.29779f, -7.5f, 0f);
        }

        if (collision.gameObject.tag == "Key")
        {
            Key.SetActive(false);
            Reveal.SetActive(false);
            keyMusic.SetActive(true);
        }

        if (collision.gameObject.tag == "Secret")
        {
            Secret.SetActive(false);
            secretUI.SetActive(true);
            fpsText.SetActive(false);
            objectText.SetActive(false);
            mainMusic.SetActive(false);
            secretMusic.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }

        if (collision.gameObject.tag == "Special")
        {
            oobUI.SetActive(true);
            fpsText.SetActive(false);
            objectText.SetActive(false);
            mainMusic.SetActive(false);
            oobMusic.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }

        if (collision.gameObject.tag == "Goal")
        {
            winUI.SetActive(true);
            fpsText.SetActive(false);
            objectText.SetActive(false);
            mainMusic.SetActive(false);
            winMusic.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BeatGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Win");
    }

    public void Resume()
    {
        secretUI.SetActive(false);
        fpsText.SetActive(true);
        objectText.SetActive(true);
        secretMusic.SetActive(false);
        mainMusic.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}