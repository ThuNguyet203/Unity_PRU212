using UnityEngine;

public class Shark : MonoBehaviour
{

    float speed = 10.0f;
    float isRight = -1f;

    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Methods
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * speed;
        float translationY = Input.GetAxis("Vertical") * speed;


        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;

        //if(translationX > 0 && isRight < 0)
        //{
        //    //spriteRenderer.flipX = true;
        //    Vector3 scale = transform.localScale;
        //    scale.x *= -1f;
        //    transform.localScale = scale;
        //    isRight = 1f;
        //}

        //if (translationX < 0 && isRight >0)
        //{
        //    //spriteRenderer.flipX = false;
        //    Vector3 scale = transform.localScale;
        //    scale.x *= -1f;
        //    transform.localScale = scale;
        //    isRight = 1f;
        //}

        if(translationX * isRight < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1f;
            transform.localScale = scale;
            isRight *= -1f;
        }
        // Move translation along the object's z-axis
        transform.Translate(translationX, translationY, 0);


        //Vector3 position = transform.position;
        //position.x += translation;
        //transform.position = position;

        ClampOnBackground();

        if (Input.GetKeyUp(KeyCode.F))
        {
            print("just release f");
        }

    }
    
    void ClampOnBackground()
    {
        Vector3 pos = transform.localPosition;
        if (pos.x < -28.5f) pos.x = -28.5f;
        if (pos.x > 28.5f) pos.x = 28.5f;
        if (pos.y < -12.1f) pos.y = -12.1f;
        if (pos.y > 12.1f) pos.y = 12.1f;
        transform.localPosition = pos;
    }
    #endregion
}
