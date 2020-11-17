using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveBall2 : MonoBehaviour
{
    public Rigidbody rb;
    public Text score2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score2.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 m = new Vector3(0, 0, -100);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 m = new Vector3(100, 0, 0);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 m = new Vector3(0, 0, 100);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 m = new Vector3(-100, 0, 0);
            rb.AddForce(m);
        }

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Capsule")
        {
            int k = int.Parse(score2.text) + 1;
            score2.text =  k.ToString();
        }
        if (col.gameObject.name == "Capsule2")
        {
            int k = int.Parse(score2.text) + 2;
            score2.text = k.ToString();
        }
        if (col.gameObject.name == "Capsule3")
        {
            int k = int.Parse(score2.text) + 3;
            score2.text = k.ToString();
        }
    }


}
