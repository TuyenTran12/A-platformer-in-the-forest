using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    bool isPressF, isTouchChest;
    private Animator playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouchChest)
        {
            isPressF = Input.GetKey(KeyCode.F);
            if (isPressF)
            {
                StartCoroutine(DestroyChest());
            }
        }
        playerAnimation.SetBool("isPressF", isPressF);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isTouchChest = true;          
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTouchChest = false;
            isPressF = false;
        }
    }
    IEnumerator DestroyChest()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
