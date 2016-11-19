using UnityEngine;
using System.Collections;


public class eating : MonoBehaviour {

    private Rigidbody2D rigidbodyComponent;

    private SpriteRenderer spriteRenderer;
    private int seednum;
    public Sprite hamster_eat0;
    public Sprite hamster_eating1;
    public Sprite hamster_eat1;
    public Sprite hamster_eat2;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject 
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = hamster_eat0; // set the sprite to sprite
    }

    // Update is called once per frame
    void Update () {
	}

    //해바라기씨 만났을 때
    void onTriggerEnter2D(Collider2D col)
    {
        //print(col.gameObject.name);
        if (col.gameObject.tag == "seed")
        {
            seednum++;
            EatingMovement();
        }
    }
    void EatingMovement()
    {
        //먹는 상태가 아니면, 먹는 상태의 sprite로 변경
        if (spriteRenderer.sprite != hamster_eating1)
        {
            spriteRenderer.sprite = hamster_eating1;
        }
        //먹고 있는 상태였다면,
        else
        {
            if (seednum == 1)
            {
                spriteRenderer.sprite = hamster_eat1;
            }
            else if(seednum >= 2)
            {
                spriteRenderer.sprite = hamster_eat2;
            }
        }
    }
}
