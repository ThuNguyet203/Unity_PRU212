using UnityEditor.SceneManagement;
using UnityEngine;

public class TeaddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Fields

    Rigidbody2D rg2d;
    public float a;
    SpriteRenderer spriteRdr;
    

    [SerializeField]
    public Sprite[] sprites; // Array of sprites to cycle through

    private int spriteIdx;

    Color teddyColor;
    int count = 0;

    #endregion
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        //khong co component
        // rg2d = gameObject.AddComponent<Rigidbody2D>();

        spriteRdr = GetComponent<SpriteRenderer>();
        spriteRdr = GetComponent<SpriteRenderer>();

        spriteIdx = Random.Range(0, 3);
        spriteRdr.sprite = sprites[spriteIdx];
        /*
         * generate 
         */

        float magnitude = Random.Range(5f, 10f);
        float phase = Random.Range(0, 360f);
        float Fx = magnitude * Mathf.Cos(phase * Mathf.Deg2Rad);
        float Fy = magnitude * Mathf.Sin(phase * Mathf.Deg2Rad);

        Vector2 force = new Vector2(Fx, Fy);

        rg2d.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TeddyBear")
        {
            print("there is a collision!");
            //print(++count);
            //Destroy(gameObject);
            SpriteRenderer collSpriteRdr = collision.gameObject.GetComponent<SpriteRenderer>();
            if(collSpriteRdr.sprite == spriteRdr.sprite)
            {
                Destroy(gameObject);
            }

        }

        //teddyColor = spriteRdr.color;
        //teddyColor.a = 0.1f;
        //spriteRdr.color = teddyColor;

        //if(teddyColor.a < 0.3f)
        //{
        //    Destroy(gameObject);
        //}
    }
}