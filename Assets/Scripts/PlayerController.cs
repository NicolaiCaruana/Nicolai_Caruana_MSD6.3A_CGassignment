using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager GM;

    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("Scripts").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y + 1, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y + 1, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y + 1, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y + 1, p1.transform.position.z);
            GM.p1Score += 1f;
        }
    }
}
