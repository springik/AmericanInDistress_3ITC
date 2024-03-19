using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueueInvoker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoYourJob());
    }

    IEnumerator DoYourJob()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            CommandQueue.Instance.ExecuteNextCommand();
        }
    }
}
