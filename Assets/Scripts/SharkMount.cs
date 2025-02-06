using UnityEngine;

public class SharkMount : MonoBehaviour
{
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TeddyBear")
        {
            Destroy(collision.gameObject);
            count++;
            print(count);
        }
    }
}
