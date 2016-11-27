using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToNextStage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

}



	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("hamster") && this.gameObject.tag.Equals("goto2"))
        {
            if(PlayerScript.sleeponce2 == 2)
            {
                Application.LoadLevel(2);
                PlayerScript.seednum = 0;
            }
        }
    }
}
