using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int coinsRequired;
    public Animator chest;
    public Sprite OpenChest;
    private bool hasRun = false;

    IEnumerator slowDown()
    {
        
        yield return new WaitForSeconds(.5f);
        Destroy(chest);
        this.GetComponent<SpriteRenderer>().sprite = OpenChest;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Singleton.Score >= coinsRequired && !hasRun)
        {
            hasRun = true;
            chest.SetBool("Coins", true);
            StartCoroutine(slowDown());
        }
    }
}
