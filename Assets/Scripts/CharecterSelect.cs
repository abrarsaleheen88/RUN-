using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharecterSelect : MonoBehaviour
{

    public GameObject[] characters;
    public Transform spawnPoint;

    public TextMeshProUGUI charName;
    private GameObject currenrChar;
    private int currentindex = 0;

    void Start()
    {
        ShowChar();
    }

    void ShowChar()
    {
        if (currenrChar != null)
        {
            Destroy(currenrChar);
        }

        currenrChar = Instantiate(characters[currentindex], spawnPoint.position,Quaternion.identity) ;//shows the selected char
        string[] names = { "Marco","Jenniefer","Logan","Mariah","Momo","PoloX","Saif365","Shauna","Suja","William"};
        charName.text = names[currentindex];
    }

    public void NextChar()
    {
        currentindex++;
        if (currentindex >= characters.Length)
        {
            currentindex = 0;
        }

        ShowChar();
    }

    public void PrevChar()
    {
        currentindex--;
        if (currentindex<0)
        {
            currentindex = characters.Length-1;
        }

        ShowChar();
    }


    public void SelectedChar()
    {
        CharManager.selectedChar = currentindex;
        SceneManager.LoadScene("Selection");
    }
}
