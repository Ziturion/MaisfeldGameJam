using UnityEngine;
using System.Collections;

public class SetRandomRotationandScale : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Randomrotation()
    {
        this.transform.Rotate(0,Random.Range(0,180),0,Space.Self);
    }
    public void RandomScale(float minscale,float maxscale)
    {
        this.transform.localScale = new Vector3(Random.Range(minscale, maxscale), Random.Range(minscale, maxscale), Random.Range(minscale, maxscale));
    }
}
