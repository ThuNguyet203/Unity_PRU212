using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rg2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    protected void Move()
    {
        rg2d = GetComponent<Rigidbody2D>();
        float magnitude = Random.Range(5f, 10f);
        float phase = Random.Range(0, 360f);
        float Fx = magnitude * Mathf.Cos(phase * Mathf.Deg2Rad);
        float Fy = magnitude * Mathf.Sin(phase * Mathf.Deg2Rad);
        Vector2 force = new Vector2(Fx, Fy);

        rg2d.AddForce(force, ForceMode2D.Impulse);
    } 
}
