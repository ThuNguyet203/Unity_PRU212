using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class TeddySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Fields
    [SerializeField]
    GameObject teddyPrefab;

    public Sprite[] sprites; // Array of sprites to cycle through

    private SpriteRenderer spriteR;
    private float elapseTime = 0f; // Tracks elapsed time
    private float duration = 5f; // Duration in seconds for sprite change
    private int spriteIdx;
    protected float spawTime = 5f;
    #endregion

    #region method
    void Start()
    {
        //  Vector3 pos = new Vector3 (0, 0, 0);
        // Instantiate(teddyPrefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        elapseTime += Time.deltaTime;
        if (elapseTime > duration)
        {
            spriteIdx = Random.Range(0, sprites.Length);
            print("enough 5s");
            float x = Random.Range(-10f, 10f);
            Vector3 spawPos = new Vector3(x, 0f, 0f);
            //Vector3 pos = new Vector3(0, 0, 0);
            Instantiate(teddyPrefab, spawPos, Quaternion.identity);
            SpriteRenderer spriteR = teddyPrefab.GetComponent<SpriteRenderer>();
            spriteR.sprite = sprites[spriteIdx];
            elapseTime = 0f;

        }
    }
    #endregion
}