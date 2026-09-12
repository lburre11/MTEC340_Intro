using UnityEngine;

public class controlFlow : MonoBehaviour
{
    public bool flag = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }

        for (int i = 0; i < 10; i++)
        {
            float answer = Mathf.Pow(2, i);
            Debug.Log($"The {i} power of 2 is {answer}");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
