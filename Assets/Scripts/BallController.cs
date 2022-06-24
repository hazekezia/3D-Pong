using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 resetPosition;
    public Rigidbody BallSpawn;

    void Start(){
        SpawnTheBall();
    }

    public void SpawnTheBall(){
        BallSpawn = GetComponent<Rigidbody>();

        if (transform.position == new Vector3(-3.71f, 0.8f, -3.88f)){
            int X0 = Random.Range(3, 4);
            int Z0 = Random.Range(3, 4);

            BallSpawn.velocity = new Vector3(X0, 0.8f, Z0);
        }
        else if (transform.position == new Vector3(3.71f, 0.8f, -3.88f)){
            int X1 = Random.Range(-3, -4);
            int Z1 = Random.Range(3, 4);

            BallSpawn.velocity = new Vector3(X1, 0.8f, Z1);
        }
        else if (transform.position == new Vector3(-3.71f, 0.8f, 3.88f)){
            int X2 = Random.Range(3, 4);
            int Z2 = Random.Range(-3, -4);

            BallSpawn.velocity = new Vector3(X2, 0.8f, Z2);
        }
        else if (transform.position == new Vector3(3.71f, 0.8f, 3.88f)){
            int X3 = Random.Range(-3, -4);
            int Z3 = Random.Range(-3, -4);

            BallSpawn.velocity = new Vector3(X3, 0.8f, Z3);
        }
    }
}
