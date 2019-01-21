using UnityEngine.SceneManagement;
using UnityEngine;

public class TransferLevel : MonoBehaviour
{
    public Level level;

    private GameObject levelDropDown;
    private LevelDropDown dropDown;

    static TransferLevel instance;

    void Awake()
    {
        levelDropDown = GameObject.Find("DropdownLevel");
        dropDown = levelDropDown.GetComponent<LevelDropDown>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Game")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().level = level;
        }
        
        dropDown.SetResource += SetLevel;
    }

    void OnLevelWasLoaded()
    {
        Awake();
    }

    private void SetLevel(Level level)
    {
        this.level = level;
    }
}
