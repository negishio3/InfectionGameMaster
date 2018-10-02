using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOfAccel : ItemBase {

    public override void Execution(GameObject obj)
    {
        int i=obj.GetComponent<PlayerNumber>().PlayerNum;
        if (EntrySystem.entryFlg[i-1])
        {
            PlayerMove PM= obj.GetComponent<PlayerMove>();
            if (PM.SpdUpFlg)
            {
                StopCoroutine(PM.spdUpCor);
                PM.spdUpCor = PM.SpeedUpCoroutine();
            }
            else
            {
                PM.SpeedUp();
            }
            
        }
        else
        {
            AIPlayer AI = obj.GetComponent<AIPlayer>();
            if (AI.SpdUpFlg)
            {
                StopCoroutine(AI.spdUpCor);
                AI.spdUpCor = AI.SpeedUpCoroutine();
            }
            else
            {
                AI.SpeedUp();
            }
            
        }
        Destroy(gameObject);
    }
}
