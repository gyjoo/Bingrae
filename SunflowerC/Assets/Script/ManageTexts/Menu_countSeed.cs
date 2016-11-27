using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Menu_countSeed : MonoBehaviour {

	public GameObject seed_count0;
	public GameObject seed_count1;
	public GameObject seed_count2;
	public GameObject seed_count3;
    public GameObject seed_count4;
    public GameObject seed_count5;
    public GameObject seed_count6;
    public GameObject seed_count7;

    // Use this for initialization
    void Start () {
		
		seed_count0.SetActive (true);
		seed_count1.SetActive (false);
		seed_count2.SetActive (false);
		seed_count3.SetActive (false);
        seed_count4.SetActive (false);
        seed_count5.SetActive (false);
        seed_count6.SetActive (false);
        seed_count7.SetActive (false);

    }
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.seednum == 1) {
			seed_count0.SetActive (false);
			seed_count1.SetActive (true);
		} 
		else if (PlayerScript.seednum == 2) {
			seed_count1.SetActive (false);
			seed_count2.SetActive (true);
		}
		else if (PlayerScript.seednum == 3) {
			seed_count2.SetActive (false);
			seed_count3.SetActive (true);
		}
        else if (PlayerScript.seednum == 4)
        {
            seed_count3.SetActive(false);
            seed_count4.SetActive(true);
        }
        else if (PlayerScript.seednum == 5)
        {
            seed_count4.SetActive(false);
            seed_count5.SetActive(true);
        }
        else if (PlayerScript.seednum == 6)
        {
            seed_count5.SetActive(false);
            seed_count6.SetActive(true);
        }
        else if (PlayerScript.seednum == 7)
        {
            seed_count6.SetActive(false);
            seed_count7.SetActive(true);
        }
    }
}
