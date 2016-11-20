using UnityEngine;

public class queue_script : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    //queue 개수에 따른 그림
    public Sprite queue0;
    public Sprite queue1;
    public Sprite queue2;
    public Sprite queue3;
    public Sprite queue4;
    public Sprite queue5;

    //햄스터 개인 캐릭터
    public GameObject hams1;
    public GameObject hams2;
    public GameObject hams3;
    public GameObject hams4;
    public GameObject hams5;
    public GameObject hams6;

    //버튼과 관련된 게임오브젝트들
    public GameObject dequeue;
    public GameObject enqueue;
    public GameObject numbutton;
    public GameObject numbutton1;
    public GameObject numbutton2;
    public GameObject numbutton3;
    public GameObject numbutton4;
    public GameObject numbutton5;
    public GameObject numbutton6;
    public GameObject enqueuenum1;
    public GameObject enqueuenum2;
    public GameObject enqueuenum3;
    public GameObject enqueuenum4;
    public GameObject enqueuenum5;
    public GameObject enqueuenum6;

    //스택이 가지고 있는 값 저장
    private int queuevalue1;
    private int queuevalue2;
    private int queuevalue3;
    private int queuevalue4;
    private int queuevalue5;

    //queue옆에 번호 붙이기 (노가다주의ㅠㅠ)
    public GameObject queuenum11;
    public GameObject queuenum12;
    public GameObject queuenum13;
    public GameObject queuenum14;
    public GameObject queuenum15;
    public GameObject queuenum16;
    public GameObject queuenum21;
    public GameObject queuenum22;
    public GameObject queuenum23;
    public GameObject queuenum24;
    public GameObject queuenum25;
    public GameObject queuenum26;
    public GameObject queuenum31;
    public GameObject queuenum32;
    public GameObject queuenum33;
    public GameObject queuenum34;
    public GameObject queuenum35;
    public GameObject queuenum36;
    public GameObject queuenum41;
    public GameObject queuenum42;
    public GameObject queuenum43;
    public GameObject queuenum44;
    public GameObject queuenum45;
    public GameObject queuenum46;
    public GameObject queuenum51;
    public GameObject queuenum52;
    public GameObject queuenum53;
    public GameObject queuenum54;
    public GameObject queuenum55;
    public GameObject queuenum56;

    // Use this for initialization
    void Start () {

        numbutton.SetActive(false);
        dequeue.SetActive(false);
        enqueue.SetActive(false);
        hams1.SetActive(false);
        hams2.SetActive(false);
        hams3.SetActive(false);
        hams4.SetActive(false);
        hams5.SetActive(false);
        enqueuenum1.SetActive(false);
        enqueuenum2.SetActive(false);
        enqueuenum3.SetActive(false);
        enqueuenum4.SetActive(false);
        enqueuenum5.SetActive(false);

        queuevalue1 = 1;
        queuevalue2 = 2;
        queuevalue3 = 3;
        queuevalue4 = 4;
        queuevalue5 = 5;

        queuenum11.SetActive(true);
        queuenum12.SetActive(false);
        queuenum13.SetActive(false);
        queuenum14.SetActive(false);
        queuenum15.SetActive(false);
        queuenum16.SetActive(false);

        queuenum21.SetActive(false);
        queuenum22.SetActive(true);
        queuenum23.SetActive(false);
        queuenum24.SetActive(false);
        queuenum25.SetActive(false);
        queuenum26.SetActive(false);

        queuenum31.SetActive(false);
        queuenum32.SetActive(false);
        queuenum33.SetActive(true);
        queuenum34.SetActive(false);
        queuenum35.SetActive(false);
        queuenum36.SetActive(false);

        queuenum41.SetActive(false);
        queuenum42.SetActive(false);
        queuenum43.SetActive(false);
        queuenum44.SetActive(true);
        queuenum45.SetActive(false);
        queuenum46.SetActive(false);

        queuenum51.SetActive(false);
        queuenum52.SetActive(false);
        queuenum53.SetActive(false);
        queuenum54.SetActive(false);
        queuenum55.SetActive(true);
        queuenum56.SetActive(false);

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = queue5; // set the sprite to sprite
    }
	
	// Update is called once per frame
	void Update () {
        //enqueue 버튼 눌렀을 때
	    if(enqueue.activeSelf == true)
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

                //이미 queue에 들어있는 것을 찾아서 active 해제하기
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
            enqueue.SetActive(false);
        }
        //1번 enqueue
        if (enqueuenum1.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams1.SetActive(false);
                queuevalue5 = 1;
                queuenum51.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams1.SetActive(false);
                queuevalue4 = 1;
                queuenum41.SetActive(true);

            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams1.SetActive(false);
                queuevalue3 = 1;
                queuenum31.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams1.SetActive(false);
                queuevalue2 = 1;
                queuenum21.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams1.SetActive(false);
                queuevalue1 = 1;
                queuenum11.SetActive(true);
            }
            enqueuenum1.SetActive(false);
        }
        //2번 enqueue
        if (enqueuenum2.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams2.SetActive(false);
                queuevalue5 = 2;
                queuenum52.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams2.SetActive(false);
                queuevalue4 = 2;
                queuenum42.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams2.SetActive(false);
                queuevalue3 = 2;
                queuenum32.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams2.SetActive(false);
                queuevalue2 = 2;
                queuenum22.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams2.SetActive(false);
                queuevalue1 = 2;
                queuenum12.SetActive(true);
            }
            enqueuenum2.SetActive(false);
        }
        //3번 enqueue
        if (enqueuenum3.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams3.SetActive(false);
                queuevalue5 = 3;
                queuenum53.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams3.SetActive(false);
                queuevalue4 = 3;
                queuenum43.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams3.SetActive(false);
                queuevalue3 = 3;
                queuenum33.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams3.SetActive(false);
                queuevalue2 = 3;
                queuenum23.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams3.SetActive(false);
                queuevalue1 = 3;
                queuenum13.SetActive(true);
            }
            enqueuenum3.SetActive(false);
        }
        //4번 enqueue
        if (enqueuenum4.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams4.SetActive(false);
                queuevalue5 = 4;
                queuenum54.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams4.SetActive(false);
                queuevalue4 = 4;
                queuenum44.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams4.SetActive(false);
                queuevalue3 = 4;
                queuenum34.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams4.SetActive(false);
                queuevalue2 = 4;
                queuenum24.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams4.SetActive(false);
                queuevalue1 = 4;
                queuenum14.SetActive(true);
            }
            enqueuenum4.SetActive(false);
        }
        //5번 enqueue
        if (enqueuenum5.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams5.SetActive(false);
                queuevalue5 = 5;
                queuenum55.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams5.SetActive(false);
                queuevalue4 = 5;
                queuenum45.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams5.SetActive(false);
                queuevalue3 = 5;
                queuenum35.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams5.SetActive(false);
                queuevalue2 = 5;
                queuenum25.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams5.SetActive(false);
                queuevalue1 = 5;
                queuenum15.SetActive(true);
            }
            enqueuenum5.SetActive(false);
        }
        //6번 enqueue
        if (enqueuenum6.activeSelf == true)
        {
            numbutton.SetActive(false);
            if (spriteRenderer.sprite == queue4)
            {
                spriteRenderer.sprite = queue5;
                hams6.SetActive(false);
                queuevalue5 = 6;
                queuenum56.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue3)
            {
                spriteRenderer.sprite = queue4;
                hams6.SetActive(false);
                queuevalue4 = 6;
                queuenum46.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue2)
            {
                spriteRenderer.sprite = queue3;
                hams6.SetActive(false);
                queuevalue3 = 6;
                queuenum36.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue2;
                hams6.SetActive(false);
                queuevalue2 = 6;
                queuenum26.SetActive(true);
            }
            else if (spriteRenderer.sprite == queue0)
            {
                spriteRenderer.sprite = queue1;
                hams6.SetActive(false);
                queuevalue1 = 6;
                queuenum16.SetActive(true);
            }
            enqueuenum6.SetActive(false);
        }

        //dequeue button 눌렀을 때
        if (dequeue.activeSelf == true)
        {
            if (numbutton.activeSelf == true)
            {
                numbutton.SetActive(false);
            }
            if (spriteRenderer.sprite == queue5)
            {
                //queue, 각 햄스터 결정
                spriteRenderer.sprite = queue4;
                if (queuevalue1 == 1)
                {
                    hams1.SetActive(true);
                    queuenum11.SetActive(false);
                }
                else if (queuevalue1 == 2)
                {
                    hams2.SetActive(true);
                    queuenum12.SetActive(false);
                }
                else if (queuevalue1 == 3)
                {
                    hams3.SetActive(true);
                    queuenum13.SetActive(false);
                }
                else if (queuevalue1 == 4)
                {
                    hams4.SetActive(true);
                    queuenum14.SetActive(false);
                }
                else if (queuevalue1 == 5)
                {
                    hams5.SetActive(true);
                    queuenum15.SetActive(false);
                }
                else if (queuevalue1 == 6)
                {
                    hams6.SetActive(true);
                    queuenum16.SetActive(false);
                }

                //숫자 인덱스 결정
                if (queuevalue2 == 1)
                {
                    queuenum21.SetActive(false);
                    queuenum11.SetActive(true);
                }
                else if (queuevalue2 == 2)
                {
                    queuenum22.SetActive(false);
                    queuenum12.SetActive(true);
                }
                else if (queuevalue2 == 3)
                {
                    queuenum23.SetActive(false);
                    queuenum13.SetActive(true);
                }
                else if (queuevalue2 == 4)
                {
                    queuenum24.SetActive(false);
                    queuenum14.SetActive(true);
                }
                else if (queuevalue2 == 5)
                {
                    queuenum25.SetActive(false);
                    queuenum15.SetActive(true);
                }
                else if (queuevalue2 == 6)
                {
                    queuenum26.SetActive(false);
                    queuenum16.SetActive(true);
                }

                if (queuevalue3 == 1)
                {
                    queuenum31.SetActive(false);
                    queuenum21.SetActive(true);
                }
                else if (queuevalue3 == 2)
                {
                    queuenum32.SetActive(false);
                    queuenum22.SetActive(true);
                }
                else if (queuevalue3 == 3)
                {
                    queuenum33.SetActive(false);
                    queuenum23.SetActive(true);
                }
                else if (queuevalue3 == 4)
                {
                    queuenum34.SetActive(false);
                    queuenum24.SetActive(true);
                }
                else if (queuevalue3 == 5)
                {
                    queuenum35.SetActive(false);
                    queuenum25.SetActive(true);
                }
                else if (queuevalue3 == 6)
                {
                    queuenum36.SetActive(false);
                    queuenum26.SetActive(true);
                }

                if (queuevalue4 == 1)
                {
                    queuenum41.SetActive(false);
                    queuenum31.SetActive(true);
                }
                else if (queuevalue4 == 2)
                {
                    queuenum42.SetActive(false);
                    queuenum32.SetActive(true);
                }
                else if (queuevalue4 == 3)
                {
                    queuenum43.SetActive(false);
                    queuenum33.SetActive(true);
                }
                else if (queuevalue4 == 4)
                {
                    queuenum44.SetActive(false);
                    queuenum34.SetActive(true);
                }
                else if (queuevalue4 == 5)
                {
                    queuenum45.SetActive(false);
                    queuenum35.SetActive(true);
                }
                else if (queuevalue4 == 6)
                {
                    queuenum46.SetActive(false);
                    queuenum36.SetActive(true);
                }

                if (queuevalue5 == 1)
                {
                    queuenum51.SetActive(false);
                    queuenum41.SetActive(true);
                }
                else if (queuevalue5 == 2)
                {
                    queuenum52.SetActive(false);
                    queuenum42.SetActive(true);
                }
                else if (queuevalue5 == 3)
                {
                    queuenum53.SetActive(false);
                    queuenum43.SetActive(true);
                }
                else if (queuevalue5 == 4)
                {
                    queuenum54.SetActive(false);
                    queuenum44.SetActive(true);
                }
                else if (queuevalue5 == 5)
                {
                    queuenum55.SetActive(false);
                    queuenum45.SetActive(true);
                }
                else if (queuevalue5 == 6)
                {
                    queuenum56.SetActive(false);
                    queuenum46.SetActive(true);
                }

                queuevalue1 = queuevalue2;
                queuevalue2 = queuevalue3;
                queuevalue3 = queuevalue4;
                queuevalue4 = queuevalue5;
                queuevalue5 = 0;

            }
            else if (spriteRenderer.sprite == queue4)
            {
                //queue, 햄스터 결정
                spriteRenderer.sprite = queue3;
                if (queuevalue1 == 1)
                {
                    hams1.SetActive(true);
                    queuenum11.SetActive(false);
                }
                else if (queuevalue1 == 2)
                {
                    hams2.SetActive(true);
                    queuenum12.SetActive(false);
                }
                else if (queuevalue1 == 3)
                {
                    hams3.SetActive(true);
                    queuenum13.SetActive(false);
                }
                else if (queuevalue1 == 4)
                {
                    hams4.SetActive(true);
                    queuenum14.SetActive(false);
                }
                else if (queuevalue1 == 5)
                {
                    hams5.SetActive(true);
                    queuenum15.SetActive(false);
                }
                else if (queuevalue1 == 6)
                {
                    hams6.SetActive(true);
                    queuenum16.SetActive(false);
                }

                //숫자 표시 변경
                if (queuevalue2 == 1)
                {
                    queuenum21.SetActive(false);
                    queuenum11.SetActive(true);
                }
                else if (queuevalue2 == 2)
                {
                    queuenum22.SetActive(false);
                    queuenum12.SetActive(true);
                }
                else if (queuevalue2 == 3)
                {
                    queuenum23.SetActive(false);
                    queuenum13.SetActive(true);
                }
                else if (queuevalue2 == 4)
                {
                    queuenum24.SetActive(false);
                    queuenum14.SetActive(true);
                }
                else if (queuevalue2 == 5)
                {
                    queuenum25.SetActive(false);
                    queuenum15.SetActive(true);
                }
                else if (queuevalue2 == 6)
                {
                    queuenum26.SetActive(false);
                    queuenum16.SetActive(true);
                }

                if (queuevalue3 == 1)
                {
                    queuenum31.SetActive(false);
                    queuenum21.SetActive(true);
                }
                else if (queuevalue3 == 2)
                {
                    queuenum32.SetActive(false);
                    queuenum22.SetActive(true);
                }
                else if (queuevalue3 == 3)
                {
                    queuenum33.SetActive(false);
                    queuenum23.SetActive(true);
                }
                else if (queuevalue3 == 4)
                {
                    queuenum34.SetActive(false);
                    queuenum24.SetActive(true);
                }
                else if (queuevalue3 == 5)
                {
                    queuenum35.SetActive(false);
                    queuenum25.SetActive(true);
                }
                else if (queuevalue3 == 6)
                {
                    queuenum36.SetActive(false);
                    queuenum26.SetActive(true);
                }

                if (queuevalue4 == 1)
                {
                    queuenum41.SetActive(false);
                    queuenum31.SetActive(true);
                }
                else if (queuevalue4 == 2)
                {
                    queuenum42.SetActive(false);
                    queuenum32.SetActive(true);
                }
                else if (queuevalue4 == 3)
                {
                    queuenum43.SetActive(false);
                    queuenum33.SetActive(true);
                }
                else if (queuevalue4 == 4)
                {
                    queuenum44.SetActive(false);
                    queuenum34.SetActive(true);
                }
                else if (queuevalue4 == 5)
                {
                    queuenum45.SetActive(false);
                    queuenum35.SetActive(true);
                }
                else if (queuevalue4 == 6)
                {
                    queuenum46.SetActive(false);
                    queuenum36.SetActive(true);
                }

                //queuevalue 변경
                queuevalue1 = queuevalue2;
                queuevalue2 = queuevalue3;
                queuevalue3 = queuevalue4;
                queuevalue4 = 0;

            }
            else if (spriteRenderer.sprite == queue3)
            {
                //queue, 각 햄스터 결정
                spriteRenderer.sprite = queue2;
                if (queuevalue1 == 1)
                {
                    hams1.SetActive(true);
                    queuenum11.SetActive(false);
                }
                else if (queuevalue1 == 2)
                {
                    hams2.SetActive(true);
                    queuenum12.SetActive(false);
                }
                else if (queuevalue1 == 3)
                {
                    hams3.SetActive(true);
                    queuenum13.SetActive(false);
                }
                else if (queuevalue1 == 4)
                {
                    hams4.SetActive(true);
                    queuenum14.SetActive(false);
                }
                else if (queuevalue1 == 5)
                {
                    hams5.SetActive(true);
                    queuenum15.SetActive(false);
                }
                else if (queuevalue1 == 6)
                {
                    hams6.SetActive(true);
                    queuenum16.SetActive(false);
                }

                //숫자 표시 변경
                if (queuevalue2 == 1)
                {
                    queuenum21.SetActive(false);
                    queuenum11.SetActive(true);
                }
                else if (queuevalue2 == 2)
                {
                    queuenum22.SetActive(false);
                    queuenum12.SetActive(true);
                }
                else if (queuevalue2 == 3)
                {
                    queuenum23.SetActive(false);
                    queuenum13.SetActive(true);
                }
                else if (queuevalue2 == 4)
                {
                    queuenum24.SetActive(false);
                    queuenum14.SetActive(true);
                }
                else if (queuevalue2 == 5)
                {
                    queuenum25.SetActive(false);
                    queuenum15.SetActive(true);
                }
                else if (queuevalue2 == 6)
                {
                    queuenum26.SetActive(false);
                    queuenum16.SetActive(true);
                }

                if (queuevalue3 == 1)
                {
                    queuenum31.SetActive(false);
                    queuenum21.SetActive(true);
                }
                else if (queuevalue3 == 2)
                {
                    queuenum32.SetActive(false);
                    queuenum22.SetActive(true);
                }
                else if (queuevalue3 == 3)
                {
                    queuenum33.SetActive(false);
                    queuenum23.SetActive(true);
                }
                else if (queuevalue3 == 4)
                {
                    queuenum34.SetActive(false);
                    queuenum24.SetActive(true);
                }
                else if (queuevalue3 == 5)
                {
                    queuenum35.SetActive(false);
                    queuenum25.SetActive(true);
                }
                else if (queuevalue3 == 6)
                {
                    queuenum36.SetActive(false);
                    queuenum26.SetActive(true);
                }

                //value 결정
                queuevalue1 = queuevalue2;
                queuevalue2 = queuevalue3;
                queuevalue3 = 0;
            }
            else if (spriteRenderer.sprite == queue2)
            {
                //queue, 각 햄스터 결정
                spriteRenderer.sprite = queue1;
                if (queuevalue1 == 1)
                {
                    hams1.SetActive(true);
                    queuenum11.SetActive(false);
                }
                else if (queuevalue1 == 2)
                {
                    hams2.SetActive(true);
                    queuenum12.SetActive(false);
                }
                else if (queuevalue1 == 3)
                {
                    hams3.SetActive(true);
                    queuenum13.SetActive(false);
                }
                else if (queuevalue1 == 4)
                {
                    hams4.SetActive(true);
                    queuenum14.SetActive(false);
                }
                else if (queuevalue1 == 5)
                {
                    hams5.SetActive(true);
                    queuenum15.SetActive(false);
                }
                else if (queuevalue1 == 6)
                {
                    hams6.SetActive(true);
                    queuenum16.SetActive(false);
                }

                //숫자 표시 변경
                if (queuevalue2 == 1)
                {
                    queuenum21.SetActive(false);
                    queuenum11.SetActive(true);
                }
                else if (queuevalue2 == 2)
                {
                    queuenum22.SetActive(false);
                    queuenum12.SetActive(true);
                }
                else if (queuevalue2 == 3)
                {
                    queuenum23.SetActive(false);
                    queuenum13.SetActive(true);
                }
                else if (queuevalue2 == 4)
                {
                    queuenum24.SetActive(false);
                    queuenum14.SetActive(true);
                }
                else if (queuevalue2 == 5)
                {
                    queuenum25.SetActive(false);
                    queuenum15.SetActive(true);
                }
                else if (queuevalue2 == 6)
                {
                    queuenum26.SetActive(false);
                    queuenum16.SetActive(true);
                }

                //queue value 변경
                queuevalue1 = queuevalue2;
                queuevalue2 = 0;
            }
            else if (spriteRenderer.sprite == queue1)
            {
                spriteRenderer.sprite = queue0;
                if (queuevalue1 == 1)
                {
                    hams1.SetActive(true);
                    queuenum11.SetActive(false);
                }
                else if (queuevalue1 == 2)
                {
                    hams2.SetActive(true);
                    queuenum12.SetActive(false);
                }
                else if (queuevalue1 == 3)
                {
                    hams3.SetActive(true);
                    queuenum13.SetActive(false);
                }
                else if (queuevalue1 == 4)
                {
                    hams4.SetActive(true);
                    queuenum14.SetActive(false);
                }
                else if (queuevalue1 == 5)
                {
                    hams5.SetActive(true);
                    queuenum15.SetActive(false);
                }
                else if (queuevalue1 == 6)
                {
                    hams6.SetActive(true);
                    queuenum16.SetActive(false);
                }
                queuevalue1 = 0;
            }

            dequeue.SetActive(false);
        }
    }
}
