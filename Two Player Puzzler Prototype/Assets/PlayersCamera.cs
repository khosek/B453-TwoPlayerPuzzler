using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersCamera : MonoBehaviour
{
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    public void LateUpdate()
    {
        this.transform.position = player1.transform.position + (player2.transform.position - player1.transform.position)/2 + new Vector3(0,0,-1);
    }
}
