using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

   public void TrailRUN()
    {
        SceneManager.LoadScene("TrailRUN");

    }

    public void ObstacleRUN()
    {
        SceneManager.LoadScene("ObstacleRun");

    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void gameExit()
    {

        Application.Quit ();    
    }

    public void charSelect()
    {
        SceneManager.LoadScene("SelectChar");
    }

}
