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

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite
    }

    void Update()
    {
        // 3 - Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 4 - Movement per direction
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

        //좌우로 움직일 때 이미지 반전
        if(inputX > 0)
        {
            ChangeTheDarnSpriteRight();

            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        else if(inputX < 0)
        {
            ChangeTheDarnSpriteLeft();

            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        
        //상하로 움직일 때 캐릭터 변경
        if(inputY > 0)
        {
            ChangeTheDarnSpriteUp();
        }
        else if(inputY < 0)
        {
            ChangeTheDarnSpriteDown();
        }

    }

    void FixedUpdate()
    {
        // 5 - Get the component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // 6 - Move the game object
        rigidbodyComponent.velocity = movement;
    }

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

}