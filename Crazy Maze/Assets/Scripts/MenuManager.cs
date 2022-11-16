using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject btnSoundOn;
    public GameObject btnSoundOff;

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void enableSound()
    {
        btnSoundOff.SetActive(false);
        btnSoundOn.SetActive(true);
    }

    public void disableSound()
    {
        btnSoundOn.SetActive(false);
        btnSoundOff.SetActive(true);
    }
}
