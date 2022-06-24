using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Timer TimerList;
    private void OnTriggerEnter(Collider other)
    { 
        Debug.Log("PowerUp Triggered");
        if(other.tag == "Player") 
        { 
            TimerList.AddTime();
            Destroy(gameObject); //destroy this gameObject (collectable object)
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
