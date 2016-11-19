using UnityEngine;

public class seeddisppear_dream : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("dreamhamster"))
            Destroy(this.gameObject);
    }

}
