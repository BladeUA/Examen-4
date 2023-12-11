using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallControl : MonoBehaviour
{
    public int xDirectionToMove;
    public float xSpeedMovement;
    public int yDirectionToMove;
    public float ySpeedMovement;
    private SpriteRenderer _spriteRenderer;
    private AudioSource _audioSource;
    private GameManagerControl gamemanager;
    private string currentType;
    void Start()
    {
        Initialize();
        GetComponents();
    }
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeedMovement * xDirectionToMove * Time.deltaTime ,transform.position.y + xSpeedMovement * yDirectionToMove * Time.deltaTime);
    }
    public void Initialize()
    {
        xDirectionToMove = GetInitialdirection();
        yDirectionToMove = GetInitialdirection();
    }
    void GetComponents()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    int GetInitialdirection()
    {
        int direction = Random.Range(0,200);
        if (direction == 50)
        {
            direction = 1;
        }
        else 
        {
            direction = -1;
        }
        return direction;
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "VerticalLimit")
        {
            yDirectionToMove = yDirectionToMove * -1;
            _audioSource.Play();
        }
        else if(collision.gameObject.tag == "Player")
        {
            xDirectionToMove = 1;
            _spriteRenderer.color = GetComponent<SpriteRenderer>().color;
            _audioSource.Play();
            currentType = collision.gameObject.GetComponent<PlayerControl>().playerType;
        }
        else if(collision.gameObject.tag == "Destroyer")
        {
            if(currentType == "red"){
                gamemanager.UpdatePlayer1Score(1);
            }else if(currentType == "blue"){
                gamemanager.UpdatePlayer2Score(1);
            }
            transform.position = new Vector2(0, 0);
            Initialize();
        }
    }
}
          