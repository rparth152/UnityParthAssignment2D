using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Movement : MonoBehaviour
{
    PhotonView view;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            float updown = Input.GetAxis("Vertical")* Speed * Time.deltaTime;
            float leftright = Input.GetAxis("Horizontal")* Speed * Time.deltaTime;
            Vector2 movement = new Vector2(leftright,updown);
            transform.Translate(movement);
        }
        
        
    }
}
