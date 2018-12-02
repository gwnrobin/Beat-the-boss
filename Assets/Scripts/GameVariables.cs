using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVariables : MonoBehaviour
{

    public Level selectedLevel;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
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
    
    public Level GetLevel()
    {
        return selectedLevel;
    }
}
