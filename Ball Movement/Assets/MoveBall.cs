using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveBall : MonoBehaviour
{   public Text score1;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        score1.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 m = new Vector3(0, 400, 0);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 m = new Vector3(0, 0, -100);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 m = new Vector3(100, 0, 0);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 m = new Vector3(0, 0, 100);
            rb.AddForce(m);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 m = new Vector3(-100,0,0);
            rb.AddForce(m);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name=="Capsule")
        {
            int k = int.Parse(score1.text) + 1;
            score1.text = k.ToString();
        }
        if (col.gameObject.name == "Capsule2")
        {
            int k = int.Parse(score1.text) + 2;
            score1.text = k.ToString();
        }
        if (col.gameObject.name == "Capsule3")
        {
            int k = int.Parse(score1.text) + 3;
            score1.text = k.ToString();
        }
    }
}
