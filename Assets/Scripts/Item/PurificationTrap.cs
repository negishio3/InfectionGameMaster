using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurificationTrap : ItemBase {
    [SerializeField]
    private GameObject purification;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public override void Execution(GameObject obj)
    {
        if (anim.GetBool("Trigger") == false)
        {
            gameObject.tag = "Untagged";
            int i = obj.GetComponent<PlayerNumber>().PlayerNum;
            if (EntrySystem.entryFlg[i - 1])
            {

            }
            else
            {
                obj.GetComponent<AIPlayer>().moveState = AIPlayer.MoveState.MOVE;
            }
            anim.SetBool("Trigger", true);
            StartCoroutine(Instant());
            Destroy(gameObject, 2f);
        }
    }

    IEnumerator Instant()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(purification, transform.position, Quaternion.identity);

    }
}
