using UnityEngine;

public class makeLevel : MonoBehaviour
{
    public Transform[] pos;
    public GameObject[] numbers;
    public bool[] check;

    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int attempts = 0;
            int z;
            do
            {
                z = Random.Range(0, pos.Length);
                attempts++;
            }
            while (check[z] && attempts < 100); 

            if (!check[z])
            {
                Instantiate(numbers[i], pos[z].position, numbers[i].transform.rotation);
                check[z] = true;
            }
        }
    }

    void Update()
    {

    }
}
