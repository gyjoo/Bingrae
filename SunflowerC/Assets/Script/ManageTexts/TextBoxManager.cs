using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	static public int TextBox = 0;


//	public PlayerController player;

	// Use this for initialization
	void Start () {
//		player = FindObjectOfType<PlayerController> ();

		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}
		textBox.SetActive (false);
	}

	void Update(){
		/*
		if (TextBox == 1) {
//			PlayerScript.stop = true;

			textBox.SetActive (true);
			theText.text = textLines [currentLine];

				if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
					currentLine += 1;
					if (currentLine > endAtLine) {
						textBox.SetActive (false);
//						PlayerScript.stop = false;
//						TextBox = 2;
					}
				}
		}
		*/

	}
}