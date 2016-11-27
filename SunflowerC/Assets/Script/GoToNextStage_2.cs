using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToNextStage_2 : MonoBehaviour {

    //미션: 2번 햄스터가 해바라기씨를 적어도 2개 먹고, 3-4-2-1-6으로 배열해라

    public GameObject stacknum13;
    public GameObject stacknum24;
    public GameObject stacknum32;
    public GameObject stacknum41;
    public GameObject stacknum56;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

		/*
		if (PlayerScript.seednum == 3 && PlayerScript.sleeponce == 1) {
			System.Threading.Thread.Sleep(100);
			Application.LoadLevel(2);
			}
	*/

}



	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("hamster") && this.gameObject.tag.Equals("goto3"))
        {
            if (PlayerScript_scene2_stack_answer.seednum >= 2)
            {
                if (stacknum13.activeSelf == true && stacknum24.activeSelf == true
                    && stacknum32.activeSelf == true && stacknum41.activeSelf == true
                    && stacknum56.activeSelf == true)
                {
                    Application.LoadLevel(3);
                }
            }
        }
    }
}
