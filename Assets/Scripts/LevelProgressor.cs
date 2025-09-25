using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgressor : MonoBehaviour
{
    void Update()
    {
        // procura todos com Tag "Brick";
        if (GameObject.FindGameObjectsWithTag("Invader").Length == 0)
        {
            var scene = SceneManager.GetActiveScene().name;

            if (scene == "Level1")
                SceneManager.LoadScene("Level2");
            else if (scene == "Level2")
                SceneManager.LoadScene("Level3");
            else if (scene == "Level3")
                SceneManager.LoadScene("Win");
        }
    }

}