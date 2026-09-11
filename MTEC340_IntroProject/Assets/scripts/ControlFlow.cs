using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        public bool flag = false;
            if(flag = true)
        {
            Debug.Log("Boolean flag is set")
        }
        else
        {
            Debug.Log("Boolean flag isn't set")
        }
        for (int i = 0; i < 10; i++)
        {
            float answer = Mathf.Pow(2, i);
            Debug.LogFormat($"The {i} power of 2 is {answer}")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
