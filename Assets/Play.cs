using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PL()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
