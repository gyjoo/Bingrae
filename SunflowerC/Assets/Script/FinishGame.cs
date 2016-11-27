using UnityEngine;
using System.Collections;

public class FinishGame : MonoBehaviour {

    //5번이 1개 이상, 3번이 3개 이상 먹고, 5-4-3-1-2 배열하세요

    public GameObject stacknum15;
    public GameObject stacknum24;
    public GameObject stacknum33;
    public GameObject stacknum41;
    public GameObject stacknum52;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag.Equals ("hamster") && this.gameObject.tag.Equals("blackhole")) {
            if (PlayerScript_scene2_stack_answer.seednum >= 1 && PlayerScript_scene2_stack_answer_2.seednum >= 3)
            {
                if (stacknum15.activeSelf == true && stacknum24.activeSelf == true
                   && stacknum33.activeSelf == true && stacknum41.activeSelf == true
                   && stacknum52.activeSelf == true)
                {
                    Application.LoadLevel(4);
                }
            }
		}
	}

}
