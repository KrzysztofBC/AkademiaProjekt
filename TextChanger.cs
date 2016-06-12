using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextChanger : MonoBehaviour {
    
    public Object parent;

	void Start ()
    {
        GetComponent<TextMesh>().text = parent.name;	
	}

}
