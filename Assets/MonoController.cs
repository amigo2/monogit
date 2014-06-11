using UnityEngine;
using System.Collections;

public class MonoController : MonoBehaviour {

    ProtoManager protoManager;

    GameObject mono;
    GameObject cycle;
    GameObject floor;
	// Use this for initialization
	void Start () 
    {
        try
        {
            protoManager = (ProtoManager)GameObject.Find("ProtoManagerObj").GetComponent<ProtoManager>();
            mono = (GameObject)GameObject.Find("Mono");
            cycle = (GameObject)GameObject.Find("Cycle");
            floor = (GameObject)GameObject.Find("floor");
        }
        catch
        {
            print("my little error");

        }
        
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Again()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll != null)
        {

            if (coll.gameObject.tag == "floor")
            {
                //mono.gameObject.transform.rotation = Quaternion.identity;
                //cycle.gameObject.transform.rotation = Quaternion.identity;
                //Destroy(mono.gameObject);
                //Destroy(cycle.gameObject);
                Debug.Log("Try again");
                protoManager.Start();

            }
        }
    }
}
