using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject[] panels;
    private int currentIndex;

    private void Start()
    {
        ClosePanels();
    }

    // SCENES //
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Panels //

    public void LoadPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
        currentIndex = index;
    }
    public void NextPanel()
    {
        if (currentIndex == panels.Length - 1)
        {
            return;
        }
        LoadPanel(currentIndex + 1);
    }
    public void PreviousPanel()
    {
        if (currentIndex == 0)
        {
            return;
        }
        LoadPanel(currentIndex - 1);
    }
    public void ClosePanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }
     
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
