using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

     screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
     screenBounds.x += 1f;

    }
    #endregion

    private Vector2 screenBounds;
    private int score;

    public Vector2 ScreenBounds {  set => screenBounds = value; }
    public int Score { get => score; set => score = value; }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
