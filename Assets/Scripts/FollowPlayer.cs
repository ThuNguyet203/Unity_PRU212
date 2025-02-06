using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    #region Fields


    [SerializeField]
    GameObject target;


    #endregion
    #region Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;
        camPos.x = target.transform.position.x;
        camPos.y = target.transform.position.y;
        transform.position = camPos;


        ClampOnBackground();
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
