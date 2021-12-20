using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sprite;
    public GameObject levelPassDiag;
    private GameObject levelPassDiagInstance;
    private Color color;
    private float force = -200f;
    private bool gameStart = false;
    private bool gameEnd = false;
    private float timer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            timer += Time.deltaTime;
        }

        if (Input.GetKeyDown("space"))
        {
            if (!gameStart)
            {
                PlayerStart();
                gameStart = true;
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

    void PlayerStart()
    {
        color = Color.blue;
        sprite.color = color;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.AddForce(new Vector2(0, force));
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "LevelPass" && !gameEnd)
        {
            Instantiate(levelPassDiag, new Vector3(0, 0, 0), Quaternion.identity);

            levelPassDiagInstance = GameObject.FindWithTag("UI_TextBox");
            levelPassDiagInstance.GetComponent<LevelPassDiag>().SetTime(timer);

            gameEnd = true;
        }
    }
}
