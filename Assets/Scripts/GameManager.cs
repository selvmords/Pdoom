using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string endingSceneName = "EndingScene";

    void Update()
    {
        if (AreAllEnemiesDead())
        {
            LoadEndingScene();
        }
    }

    bool AreAllEnemiesDead()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            if (enemy.GetComponent<Enemy>().IsAlive)
            {
                return false;
            }
        }

        return true;
    }

    void LoadEndingScene()
    {
        SceneManager.LoadScene("Playground");
    }
}
