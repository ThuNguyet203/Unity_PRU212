using UnityEngine;

public class Square : MonoBehaviour
{
    
    Vector3 position;
    float step = 0.05f;
    float direction = 1f;
    Transform circle;
    float duration = 1f;
    float elapseTime = 5f;
    public Sprite[] sprites = new Sprite[1]; 
    int spriteIdx = 0; // Initialize sprite index
    SpriteRenderer spriteR; // Declare SpriteRenderer

    //SpriteRenderer spriteR = GetComponent<SpriteRenderer>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;
        print(position);
        circle = transform.GetChild(0);
        spriteR = GetComponent<SpriteRenderer>();

        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogError("Sprites array is not assigned or has no elements! Please assign sprites in the Unity Editor.");
        }
        else
        {
            Debug.Log($"Sprites array is correctly assigned with {sprites.Length} sprites.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        if (position.x < -8 || position.x > 8 ) direction *= -1f;
        position.x += direction * step;
        transform.position = position;

        circle.RotateAround(position, Vector3.forward, 0.5f);
        //transform.RotateAround(new Vector3(0,0,0), new Vector3(0,0,1), 1);

        //transform.GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
        elapseTime += Time.deltaTime;
        if (elapseTime > duration ) 
        {
            if (sprites != null && sprites.Length > 0)
            {
                spriteIdx = (spriteIdx + 1) % sprites.Length;
                spriteR.sprite = sprites[spriteIdx];
            }
            else
            {
                Debug.LogError("Sprites array is not assigned or is empty!");
            }

            elapseTime = 0f;
        }
    }
}
