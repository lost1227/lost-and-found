using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakScript : MonoBehaviour
{

    public GameObject lineFab;
    private LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if(line == null)
        {
            GameObject obj = Instantiate(lineFab);
            obj.transform.position = Vector3.zero;
            line = obj.GetComponent<LineRenderer>();
        }

        line.SetPositions(new Vector3[] { transform.position, other.transform.position });
        
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (line != null)
            GameObject.Destroy(line.gameObject);
        line = null;
    }
}
