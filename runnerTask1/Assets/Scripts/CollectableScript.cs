using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollectableScript : MonoBehaviour
{

    private float rotateSpeed=8;
   
    void Update()
    {
        transform.Rotate(new Vector3(0,0,45)*Time.deltaTime*rotateSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.DOScale(Vector3.zero, 1f);
            Destroy(this.gameObject, 3f);
        }
    }
}
