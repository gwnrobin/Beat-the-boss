using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVariables : MonoBehaviour
{
    private Level selectedLevel;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "LevelSelector")
        {
            difficultyValue = difficultyManager.difficultyValue;
            selectedMusic = manageOptions.musicDropDown.value;
        }
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void SetLevel(Level level)
    {
        selectedLevel = level;
    }
}
