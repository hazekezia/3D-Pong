using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    
    private Rigidbody RigibodyPaddle;
    public int speed;
    public KeyCode kiri, kanan, atas, bawah;
    
    void Start(){
        RigibodyPaddle = GetComponent<Rigidbody>();
    }
    void Update(){
        MoveObject(GetInput());  
    }

    private Vector3 GetInput(){
        if (Input.GetKey(kiri)){
            return Vector3.left * speed;
        }
        else if (Input.GetKey(kanan)){
            return Vector3.right * speed;
        }
        else if (Input.GetKey(atas)){
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(bawah)){
            return Vector3.back * speed;
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement){
        RigibodyPaddle.velocity = movement;
    }
}
