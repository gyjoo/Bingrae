using UnityEngine;

public class stack_script : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    //stack 개수에 따른 그림
    public Sprite stack0;
    public Sprite stack1;
    public Sprite stack2;
    public Sprite stack3;
    public Sprite stack4;
    public Sprite stack5;

    //햄스터 개인 캐릭터
    public GameObject hams1;
    public GameObject hams2;
    public GameObject hams3;
    public GameObject hams4;
    public GameObject hams5;
    public GameObject hams6;

    //버튼과 관련된 게임오브젝트들
    public GameObject pop;
    public GameObject push;
    public GameObject numbutton;
    public GameObject numbutton1;
    public GameObject numbutton2;
    public GameObject numbutton3;
    public GameObject numbutton4;
    public GameObject numbutton5;
    public GameObject numbutton6;
    public GameObject pushnum1;
    public GameObject pushnum2;
    public GameObject pushnum3;
    public GameObject pushnum4;
    public GameObject pushnum5;
    public GameObject pushnum6;

    //스택이 가지고 있는 값 저장
    private int stackvalue1;
    private int stackvalue2;
    private int stackvalue3;
    private int stackvalue4;
    private int stackvalue5;

    //stack옆에 번호 붙이기 (노가다주의ㅠㅠ)
    public GameObject stacknum11;
    public GameObject stacknum12;
    public GameObject stacknum13;
    public GameObject stacknum14;
    public GameObject stacknum15;
    public GameObject stacknum16;
    public GameObject stacknum21;
    public GameObject stacknum22;
    public GameObject stacknum23;
    public GameObject stacknum24;
    public GameObject stacknum25;
    public GameObject stacknum26;
    public GameObject stacknum31;
    public GameObject stacknum32;
    public GameObject stacknum33;
    public GameObject stacknum34;
    public GameObject stacknum35;
    public GameObject stacknum36;
    public GameObject stacknum41;
    public GameObject stacknum42;
    public GameObject stacknum43;
    public GameObject stacknum44;
    public GameObject stacknum45;
    public GameObject stacknum46;
    public GameObject stacknum51;
    public GameObject stacknum52;
    public GameObject stacknum53;
    public GameObject stacknum54;
    public GameObject stacknum55;
    public GameObject stacknum56;

    // Use this for initialization
    void Start () {

        numbutton.SetActive(false);
        pop.SetActive(false);
        push.SetActive(false);
        hams1.SetActive(false);
        hams2.SetActive(false);
        hams3.SetActive(false);
        hams4.SetActive(false);
        hams5.SetActive(false);
        pushnum1.SetActive(false);
        pushnum2.SetActive(false);
        pushnum3.SetActive(false);
        pushnum4.SetActive(false);
        pushnum5.SetActive(false);

        stackvalue1 = 1;
        stackvalue2 = 2;
        stackvalue3 = 3;
        stackvalue4 = 4;
        stackvalue5 = 5;

        stacknum11.SetActive(true);
        stacknum12.SetActive(false);
        stacknum13.SetActive(false);
        stacknum14.SetActive(false);
        stacknum15.SetActive(false);
        stacknum16.SetActive(false);

        stacknum21.SetActive(false);
        stacknum22.SetActive(true);
        stacknum23.SetActive(false);
        stacknum24.SetActive(false);
        stacknum25.SetActive(false);
        stacknum26.SetActive(false);

        stacknum31.SetActive(false);
        stacknum32.SetActive(false);
        stacknum33.SetActive(true);
        stacknum34.SetActive(false);
        stacknum35.SetActive(false);
        stacknum36.SetActive(false);

        stacknum41.SetActive(false);
        stacknum42.SetActive(false);
        stacknum43.SetActive(false);
        stacknum44.SetActive(true);
        stacknum45.SetActive(false);
        stacknum46.SetActive(false);

        stacknum51.SetActive(false);
        stacknum52.SetActive(false);
        stacknum53.SetActive(false);
        stacknum54.SetActive(false);
        stacknum55.SetActive(true);
        stacknum56.SetActive(false);

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = stack5; // set the sprite to sprite
    }
	
	// Update is called once per frame
	void Update () {
        //push 버튼 눌렀을 때
	    if(push.activeSelf == true)
        {
            if(numbutton.activeSelf == true)
                numbutton.SetActive(false);
            else
            {
                //일단 전부 set하기
                numbutton.SetActive(true);
                numbutton1.SetActive(true);
                numbutton2.SetActive(true);
                numbutton3.SetActive(true);
                numbutton4.SetActive(true);
                numbutton5.SetActive(true);
                numbutton6.SetActive(true);

                //이미 stack에 들어있는 것을 찾아서 active 해제하기
                if (hams1.activeSelf == false)
                    numbutton1.SetActive(false);
                if (hams2.activeSelf == false)
                    numbutton2.SetActive(false);
                if (hams3.activeSelf == false)
                    numbutton3.SetActive(false);
                if (hams4.activeSelf == false)
                    numbutton4.SetActive(false);
                if (hams5.activeSelf == false)
                    numbutton5.SetActive(false);
                if (hams6.activeSelf == false)
                    numbutton6.SetActive(false);
            }
            push.SetActive(false);
        }
        //1번 push
        if (pushnum1.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams1.SetActive(false);
                stackvalue5 = 1;
                stacknum51.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams1.SetActive(false);
                stackvalue4 = 1;
                stacknum41.SetActive(true);

            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams1.SetActive(false);
                stackvalue3 = 1;
                stacknum31.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams1.SetActive(false);
                stackvalue2 = 1;
                stacknum21.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams1.SetActive(false);
                stackvalue1 = 1;
                stacknum11.SetActive(true);
            }
            pushnum1.SetActive(false);
        }
        //2번 push
        if (pushnum2.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams2.SetActive(false);
                stackvalue5 = 2;
                stacknum52.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams2.SetActive(false);
                stackvalue4 = 2;
                stacknum42.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams2.SetActive(false);
                stackvalue3 = 2;
                stacknum32.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams2.SetActive(false);
                stackvalue2 = 2;
                stacknum22.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams2.SetActive(false);
                stackvalue1 = 2;
                stacknum12.SetActive(true);
            }
            pushnum2.SetActive(false);
        }
        //3번 push
        if (pushnum3.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams3.SetActive(false);
                stackvalue5 = 3;
                stacknum53.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams3.SetActive(false);
                stackvalue4 = 3;
                stacknum43.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams3.SetActive(false);
                stackvalue3 = 3;
                stacknum33.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams3.SetActive(false);
                stackvalue2 = 3;
                stacknum23.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams3.SetActive(false);
                stackvalue1 = 3;
                stacknum13.SetActive(true);
            }
            pushnum3.SetActive(false);
        }
        //4번 push
        if (pushnum4.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams4.SetActive(false);
                stackvalue5 = 4;
                stacknum54.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams4.SetActive(false);
                stackvalue4 = 4;
                stacknum44.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams4.SetActive(false);
                stackvalue3 = 4;
                stacknum34.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams4.SetActive(false);
                stackvalue2 = 4;
                stacknum24.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams4.SetActive(false);
                stackvalue1 = 4;
                stacknum14.SetActive(true);
            }
            pushnum4.SetActive(false);
        }
        //5번 push
        if (pushnum5.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams5.SetActive(false);
                stackvalue5 = 5;
                stacknum55.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams5.SetActive(false);
                stackvalue4 = 5;
                stacknum45.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams5.SetActive(false);
                stackvalue3 = 5;
                stacknum35.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams5.SetActive(false);
                stackvalue2 = 5;
                stacknum25.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams5.SetActive(false);
                stackvalue1 = 5;
                stacknum15.SetActive(true);
            }
            pushnum5.SetActive(false);
        }
        //6번 push
        if (pushnum6.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack5;
                hams6.SetActive(false);
                stackvalue5 = 6;
                stacknum56.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack4;
                hams6.SetActive(false);
                stackvalue4 = 6;
                stacknum46.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack3;
                hams6.SetActive(false);
                stackvalue3 = 6;
                stacknum36.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack2;
                hams6.SetActive(false);
                stackvalue2 = 6;
                stacknum26.SetActive(true);
            }
            else if (spriteRenderer.sprite == stack0)
            {
                spriteRenderer.sprite = stack1;
                hams6.SetActive(false);
                stackvalue1 = 6;
                stacknum16.SetActive(true);
            }
            pushnum6.SetActive(false);
        }

        //pop button 눌렀을 때
        if (pop.activeSelf == true)
        {
            if (numbutton.activeSelf == true)
            {
                numbutton.SetActive(false);
            }
            if (spriteRenderer.sprite == stack5)
            {
                spriteRenderer.sprite = stack4;
                if (stackvalue5 == 1)
                {
                    hams1.SetActive(true);
                    stacknum51.SetActive(false);
                }
                else if (stackvalue5 == 2)
                {
                    hams2.SetActive(true);
                    stacknum52.SetActive(false);
                }
                else if (stackvalue5 == 3)
                {
                    hams3.SetActive(true);
                    stacknum53.SetActive(false);
                }
                else if (stackvalue5 == 4)
                {
                    hams4.SetActive(true);
                    stacknum54.SetActive(false);
                }
                else if (stackvalue5 == 5)
                {
                    hams5.SetActive(true);
                    stacknum55.SetActive(false);
                }
                else if (stackvalue5 == 6)
                {
                    hams6.SetActive(true);
                    stacknum56.SetActive(false);
                }
                stackvalue5 = 0;
            }
            else if (spriteRenderer.sprite == stack4)
            {
                spriteRenderer.sprite = stack3;
                if (stackvalue4 == 1)
                {
                    hams1.SetActive(true);
                    stacknum41.SetActive(false);
                }
                else if (stackvalue4 == 2)
                {
                    hams2.SetActive(true);
                    stacknum42.SetActive(false);
                }
                else if (stackvalue4 == 3)
                {
                    hams3.SetActive(true);
                    stacknum43.SetActive(false);
                }
                else if (stackvalue4 == 4)
                {
                    hams4.SetActive(true);
                    stacknum44.SetActive(false);
                }
                else if (stackvalue4 == 5)
                {
                    hams5.SetActive(true);
                    stacknum45.SetActive(false);
                }
                else if (stackvalue4 == 6)
                {
                    hams6.SetActive(true);
                    stacknum46.SetActive(false);
                }
                stackvalue4 = 0;
            }
            else if (spriteRenderer.sprite == stack3)
            {
                spriteRenderer.sprite = stack2;
                if (stackvalue3 == 1)
                {
                    hams1.SetActive(true);
                    stacknum31.SetActive(false);
                }
                else if (stackvalue3 == 2)
                {
                    hams2.SetActive(true);
                    stacknum32.SetActive(false);
                }
                else if (stackvalue3 == 3)
                {
                    hams3.SetActive(true);
                    stacknum33.SetActive(false);
                }
                else if (stackvalue3 == 4)
                {
                    hams4.SetActive(true);
                    stacknum34.SetActive(false);
                }
                else if (stackvalue3 == 5)
                {
                    hams5.SetActive(true);
                    stacknum35.SetActive(false);
                }
                else if (stackvalue3 == 6)
                {
                    hams6.SetActive(true);
                    stacknum36.SetActive(false);
                }
                stackvalue3 = 0;
            }
            else if (spriteRenderer.sprite == stack2)
            {
                spriteRenderer.sprite = stack1;
                if (stackvalue2 == 1)
                {
                    hams1.SetActive(true);
                    stacknum21.SetActive(false);
                }
                else if (stackvalue2 == 2)
                {
                    hams2.SetActive(true);
                    stacknum22.SetActive(false);
                }
                else if (stackvalue2 == 3)
                {
                    hams3.SetActive(true);
                    stacknum23.SetActive(false);
                }
                else if (stackvalue2 == 4)
                {
                    hams4.SetActive(true);
                    stacknum24.SetActive(false);
                }
                else if (stackvalue2 == 5)
                {
                    hams5.SetActive(true);
                    stacknum25.SetActive(false);
                }
                else if (stackvalue2 == 6)
                {
                    hams6.SetActive(true);
                    stacknum26.SetActive(false);
                }
                stackvalue2 = 0;
            }
            else if (spriteRenderer.sprite == stack1)
            {
                spriteRenderer.sprite = stack0;
                if (stackvalue1 == 1)
                {
                    hams1.SetActive(true);
                    stacknum11.SetActive(false);
                }
                else if (stackvalue1 == 2)
                {
                    hams2.SetActive(true);
                    stacknum12.SetActive(false);
                }
                else if (stackvalue1 == 3)
                {
                    hams3.SetActive(true);
                    stacknum13.SetActive(false);
                }
                else if (stackvalue1 == 4)
                {
                    hams4.SetActive(true);
                    stacknum14.SetActive(false);
                }
                else if (stackvalue1 == 5)
                {
                    hams5.SetActive(true);
                    stacknum15.SetActive(false);
                }
                else if (stackvalue1 == 6)
                {
                    hams6.SetActive(true);
                    stacknum16.SetActive(false);
                }
                stackvalue1 = 0;
            }

            pop.SetActive(false);
        }
    }
}
