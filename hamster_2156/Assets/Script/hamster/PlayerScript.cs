using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// 1 - The speed of the ship
    /// </summary>
    public Vector2 speed = new Vector2(50, 50);

    // 2 - Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    private SpriteRenderer spriteRenderer;
    public Sprite sprite1; //옆모습1
    public Sprite sprite2; //옆모습2
    public Sprite sprite3; //뒷모습1
    public Sprite sprite4; //뒷모습2
    public Sprite sprite5; //앞모습1
    public Sprite sprite6; //앞모습2

    //해바라기씨 먹는것과 관련
    private int seednum; //먹은 개수
    private int seedcount;
    public Sprite hamster_eat0; //앞모습
    public Sprite hamster_eating1; //먹는 모습
    public Sprite hamster_eat1; //조금 먹었을때
    public Sprite hamster_eat2; //많이 먹었을때

    //자는 것 관련
    private int sleep;
    private int sleepcount;
    public Sprite hamster_sleep;
    public GameObject sleep_sit;

    private float inputX, inputY;

    void Start()
    {
        sleep_sit.SetActive(false);
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite

        seedcount = 0;
        inputX = 0;
        inputY = 0;
        sleep = 0;
    }

    void Update()
    {
        if (seedcount > 0)
        {
            if (seedcount % 2 == 1)
            {
                spriteRenderer.sprite = hamster_eating1;
            }
            else if (seedcount % 2 == 0)
            {
                if (seednum == 1)
                    spriteRenderer.sprite = hamster_eat0;
                else if (seednum == 2)
                    spriteRenderer.sprite = hamster_eat1;
                else
                    spriteRenderer.sprite = hamster_eat2;
            }

            seedcount++;
            if (seedcount == 11)
                seedcount = 0;

            System.Threading.Thread.Sleep(80);

        }
        else if(sleep == 1)
        {
            spriteRenderer.sprite = hamster_sleep;
            if (sleepcount == 20)
            {
                sleep_sit.SetActive(true);
                sleepcount++;
            }
            else if (sleepcount < 20)
            {
                sleepcount++;
            }
            else if (sleepcount == 21 && sleep_sit.activeSelf == false)
            {
                sleepcount = 0;
                sleep = 0;
                spriteRenderer.sprite = sprite1;
            }
        }
        else
        {
            // 3 - Retrieve axis information
            inputX = Input.GetAxis("Horizontal");
            inputY = Input.GetAxis("Vertical");

            // 4 - Movement per direction
            movement = new Vector2(
              speed.x * inputX,
              speed.y * inputY);

            //좌우로 움직일 때 이미지 반전
            if (inputX > 0)
            {
                ChangeTheDarnSpriteRight();

                Vector3 scale = transform.localScale;
                scale.x = -Mathf.Abs(scale.x);
                transform.localScale = scale;
            }
            else if (inputX < 0)
            {
                ChangeTheDarnSpriteLeft();

                Vector3 scale = transform.localScale;
                scale.x = Mathf.Abs(scale.x);
                transform.localScale = scale;
            }

            //상하로 움직일 때 캐릭터 변경
            if (inputY > 0)
            {
                ChangeTheDarnSpriteUp();
            }
            else if (inputY < 0)
            {
                ChangeTheDarnSpriteDown();
            }
        }
    }

    void FixedUpdate()
    {
        if (seedcount == 0 && sleep == 0)
        {
            // 5 - Get the component and store the reference
            if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

            // 6 - Move the game object
            rigidbodyComponent.velocity = movement;
        }
        else
        {
            Vector2 zero = new Vector2(0, 0);
            rigidbodyComponent.velocity = zero;
        }
    }

    //캐릭터 이동시 SPRITE 변경
    void ChangeTheDarnSpriteRight()
    {
        if (spriteRenderer.sprite == sprite1)
            spriteRenderer.sprite = sprite2;
        else if (spriteRenderer.sprite == sprite2)
            spriteRenderer.sprite = sprite1;
        else
            spriteRenderer.sprite = sprite1;
    }
    void ChangeTheDarnSpriteLeft()
    {
        if (spriteRenderer.sprite == sprite1)
            spriteRenderer.sprite = sprite2;
        else if (spriteRenderer.sprite == sprite2)
            spriteRenderer.sprite = sprite1;
        else
            spriteRenderer.sprite = sprite1;
    }
    void ChangeTheDarnSpriteUp()
    {
        if (spriteRenderer.sprite == sprite3)
            spriteRenderer.sprite = sprite4;
        else if (spriteRenderer.sprite == sprite4)
            spriteRenderer.sprite = sprite3;
        else
            spriteRenderer.sprite = sprite3;
    }
    void ChangeTheDarnSpriteDown()
    {
        if (spriteRenderer.sprite == sprite5)
            spriteRenderer.sprite = sprite6;
        else if (spriteRenderer.sprite == sprite6)
            spriteRenderer.sprite = sprite5;
        else
            spriteRenderer.sprite = sprite5;
    }

    //충돌감지
    void OnTriggerEnter2D(Collider2D col)
    {
        //해바라기씨 만났을 때
        if (col.gameObject.tag.Equals("seed"))
        {
            seednum++;
            seedcount = 1;
            spriteRenderer.sprite = hamster_eating1;
            inputX = 0;
            inputY = 0;
        }

        //침대 만났을 때
        if (col.gameObject.tag.Equals("bed"))
        {
            inputX = 0;
            inputY = 0;

            spriteRenderer.sprite = hamster_sleep;
            sleep = 1;
        }
    }
}