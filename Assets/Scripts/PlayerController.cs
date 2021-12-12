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

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x, p1.transform.position.y - 1, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x - 1, p1.transform.position.y, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            p1.transform.position = new Vector3(p1.transform.position.x + 1, p1.transform.position.y, p1.transform.position.z);
            GM.p1Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            p2.transform.position = new Vector3(p2.transform.position.x, p2.transform.position.y + 1, p2.transform.position.z);
            GM.p2Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            p2.transform.position = new Vector3(p2.transform.position.x, p2.transform.position.y - 1, p2.transform.position.z);
            GM.p2Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            p2.transform.position = new Vector3(p2.transform.position.x - 1, p2.transform.position.y, p2.transform.position.z);
            GM.p2Score += 1f;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            p2.transform.position = new Vector3(p2.transform.position.x + 1, p2.transform.position.y, p2.transform.position.z);
            GM.p2Score += 1f;
        }
    }
}
