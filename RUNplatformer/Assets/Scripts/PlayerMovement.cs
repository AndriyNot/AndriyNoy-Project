using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private int jump = 380;
    public Animator animator;

    private bool IsJump;

    public GameObject gameOver;
    public int clikindex;

    public GameObject[] ButtonJump;
    public int indexCharacter;

    public Vector2 centePosition;
    public Vector2 posittion;
    private float progress;
    private float timer;

    public SpriteRenderer renderers;
    public int index;

    private void Awake()
    {
        index = 0;
        PlayerPrefs.SetInt("bonus", index);
        Time.timeScale = 1;
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }


    private void FixedUpdate()
    {

        float posX = transform.position.x;
        posittion = transform.position;
        if (posX < 1.15)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                transform.position = Vector2.Lerp(posittion, centePosition, progress + 0.002f);
                
            }
            if (posX >= 1.15)
            {
                timer = 0;
            }
            
        }
    }
    private void Update()
    {
        renderers = GetComponent<SpriteRenderer>();
        index = PlayerPrefs.GetInt("bonus");

        if (index == 1)
        {
            renderers.color = new Color(1, 1, 1, 0.5f);
        }
        if (index != 1)
        {
            renderers.color = new Color(1, 1, 1, 1);
        }
       
        
        animator.SetBool("jump", IsJump);
        IsJump = false;

        GameOver();

    }

    

    public void selectCharacter()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (clikindex >= 0)
            {
                clikindex = 0;
            }

        }
        if (collision.gameObject.CompareTag("pastka"))
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }

    public void ClickJump()
    {


        clikindex += 1;



        //transform.Translate(new Vector2(0, 1) * 50 * Time.deltaTime);
        float posy = transform.position.y;
        //if (posy <= -3.24f)
        //{
        //    _rb.AddForce(new Vector2(0, 1) * jump);
        //    IsJump = true;
        //}
        if (clikindex >= 0 && clikindex <= 2)
        {
            _rb.AddForce(new Vector2(0, 1) * jump);
            IsJump = true;
        }

    }
    public void GameOver()
    {
        float posx = transform.position.x;

        if (posx <= -9.72)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;


        }
        //if (Time.timeScale == 0)
        //{
        //    gameOver.SetActive(true);
        //}
        //if (Time.timeScale == 1)
        //{
        //    gameOver.SetActive(false);
        //}
    }

    public void ButtonGameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  
       
    }

}
