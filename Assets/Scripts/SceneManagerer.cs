using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagerer: MonoBehaviour
{
    public AudioSource buttonSound;
    public GameObject WarningWebVersion;

    public void ChangeSceneTo(int changeToSceneTo)
    {
        buttonSound.Play();
        SceneManager.LoadScene(changeToSceneTo);
    }

    public void QuitGame()
    {
        buttonSound.Play();
        Application.Quit();
        if(!WarningWebVersion == null)
            WarningWebVersion.SetActive(true);
    }
}
