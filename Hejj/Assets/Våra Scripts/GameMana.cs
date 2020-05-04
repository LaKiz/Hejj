using UnityEngine;
using System.Collections;

public class GameMana : MonoBehaviour {

    public static GameMana instance = null;
    public BoardManager boardScript;
    public int playerFoodPoints = 100;						//Starting value for Player food points.
    [HideInInspector] public bool playersTurn = true;		//Boolean to check if it's players turn, hidden in inspector but public.

    private int level = 3;


    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
        boardScript.SetupScene(level);
    }

    //GameOver is called when the player reaches 0 food points
    public void GameOver()
    {
        //Disable this GameManager.
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}