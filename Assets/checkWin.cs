using UnityEngine;
using UnityEngine.SceneManagement;

public class checkWin : MonoBehaviour
{
    public Transform[] staticPosition;
    public GameObject[] dynamicPosition;
    public GameObject win;

    void Start()
    {
        dynamicPosition = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     check();
        // }
    }

    public void check()
    {
        int correctCount = 0;

        for (int i = 0; i < staticPosition.Length; i++)
        {
            if (i < dynamicPosition.Length)
            {
                float distance = Vector3.Distance(staticPosition[i].position, dynamicPosition[i].transform.position);
                if (distance < 0.01f)
                {
                    correctCount++;
                }
            }
        }

        if (correctCount == staticPosition.Length)
        {
            Debug.Log("All in correct positions! You win!");
            win.SetActive(true);
        }
    }

    public void WIN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
