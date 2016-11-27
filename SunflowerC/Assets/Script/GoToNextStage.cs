using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToNextStage : MonoBehaviour {

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
		if(col.gameObject.tag.Equals("hamster") && this.gameObject.tag.Equals("goto2"))
        {
            Application.LoadLevel(2);
            PlayerScript.seednum = 0;
        }


        if (col.gameObject.tag.Equals("hamster") && this.gameObject.tag.Equals("goto3"))
        {
            Application.LoadLevel(3);
            PlayerScript.seednum = 0;
        }

    }
}
